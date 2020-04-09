﻿using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace AutoValidate
{
    class Program
    {
        String exeDir;
        String exePath;
        String exeArgs;
        private Boolean showInfo = false;

        Int32 executionCounter = 1;
        FileSystemWatcher watcher;

        public Program()
        {
            watcher = new FileSystemWatcher();
            watcher.Path = ".";
        }

        void ParseArguments(String[] args)
        {
            Int32 i = 0;

            String GetArg(String errorMsg)
            {
                if (i >= args.Length)
                    throw new Exception($"Missing {errorMsg} parameter");

                String arg = args[i++].Trim();
                if ((arg[0] == '"') && (arg[arg.Length - 1] == '"'))
                    arg = arg.Substring(1, arg.Length - 2);
                return arg;
            }

            while (i < args.Length)
            {
                String arg = GetArg("arg").ToUpper();
                switch (arg)
                {
                    case "-D":
                        Environment.CurrentDirectory = exeDir = GetArg("-d");
                        break;

                    case "-W":
                        watcher.Path = GetArg("-w");
                        break;

                    case "-C":
                        this.exePath = GetArg("-c");
                        break;

                    case "-A":
                        this.exeArgs = GetArg("-a");
                        break;

                    default:
                        throw new Exception($"Unknown arg {arg}");
                }
            }
        }

        AutoResetEvent wake = new AutoResetEvent(false);
        bool doneFlag = false;

        void RunCommand()
        {
            while (true)
            {
                try
                {
                    // Wait for no events for timeout.
                    wake.WaitOne();
                    while ((this.doneFlag == false) && (wake.WaitOne(1000) == true))
                        Console.WriteLine("Additional wake events received. Restarting wait");

                    if (this.doneFlag == true)
                        return;
                    this.ExecuteCommand();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
        }


        void ExecuteCommand()
        {
            using (Mutex gMtx = new Mutex(false, "AutoMate"))
            {
                Console.Clear();
                DateTime dt = DateTime.Now;
                gMtx.WaitOne(10 * 1000);
                TimeSpan ts = DateTime.Now - dt;
                Console.WriteLine($"Waited {ts.TotalMilliseconds}ms for access");
                Thread.Sleep(100);

                Console.WriteLine($"{executionCounter++}. Executing {this.exePath} {this.exeArgs}");
                this.Execute(this.exeDir, this.exePath, this.exeArgs);
            }

            Console.WriteLine("Command complete");
            Console.WriteLine("Press 'q' to quit.");
        }

        void Message(ConsoleColor fgColor, String msg)
        {
            String msgLevel = msg.Trim().ToUpper();
            if (msgLevel.StartsWith("INFO"))
            {
                if (showInfo == false)
                    return;
                fgColor = ConsoleColor.White;
            }
            else if (msgLevel.StartsWith("NOTE"))
                fgColor = ConsoleColor.Green;
            else if (msgLevel.StartsWith("WARN"))
                fgColor = ConsoleColor.DarkYellow;
            else if (msgLevel.StartsWith("ERROR"))
                fgColor = ConsoleColor.Red;

            Console.ForegroundColor = fgColor;
            Console.WriteLine(msg);
            Console.ForegroundColor = ConsoleColor.White;
        }

        protected Boolean Execute(String workingDir,
            String executablePath,
            String arguments)
        {
            async Task ReadOutAsync(Process p)
            {
                do
                {
                    String s = await p.StandardOutput.ReadLineAsync();
                    s = s?.Replace("\r", "")?.Replace("\n", "")?.Trim();
                    if (String.IsNullOrEmpty(s) == false)
                        Message(ConsoleColor.White, s);
                } while (p.StandardOutput.EndOfStream == false);
            }

            async Task ReadErrAsync(Process p)
            {
                do
                {
                    String s = await p.StandardError.ReadLineAsync();
                    s = s?.Replace("\r", "")?.Replace("\n", "")?.Trim();
                    if (String.IsNullOrEmpty(s) == false)
                        Message(ConsoleColor.Red, s);
                } while (p.StandardError.EndOfStream == false);
            }

            using (Process p = new Process())
            {
                p.StartInfo.FileName = executablePath;
                p.StartInfo.Arguments = arguments;
                p.StartInfo.WindowStyle = ProcessWindowStyle.Maximized;
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.RedirectStandardOutput = true;
                p.StartInfo.RedirectStandardError = true;
                p.StartInfo.WorkingDirectory = workingDir;
                p.Start();
                Task errTask = ReadErrAsync(p);
                Task outTask = ReadOutAsync(p);
                p.WaitForExit(); // Waits here for the process to exit.    }
                errTask.Wait();
                outTask.Wait();
                return p.ExitCode == 0;
            }
        }

        void Run()
        {

            // Watch for changes in LastAccess and LastWrite times, and
            // the renaming of files or directories.
            watcher.NotifyFilter = NotifyFilters.LastAccess
                                   | NotifyFilters.LastWrite
                                   | NotifyFilters.FileName
                                   | NotifyFilters.DirectoryName;

            watcher.Filter = "*.fsh";
            // Add event handlers.
            watcher.Changed += OnChanged;
            watcher.Created += OnChanged;
            watcher.Deleted += OnChanged;
            watcher.Renamed += OnChanged;
            this.watcher.IncludeSubdirectories = true;

            // Begin watching.
            watcher.EnableRaisingEvents = true;

            Task runTask = new Task(() => this.RunCommand());
            runTask.Start();

            // Wait for the user to quit the program.
            do
            {
                this.wake.Set();
            } while (Console.Read() != 'q');

            this.doneFlag = true;
            this.wake.Set();
        }

        void OnChanged(object source, FileSystemEventArgs e)
        {
            this.watcher.EnableRaisingEvents = false;
            this.wake.Set();
            this.watcher.EnableRaisingEvents = true;
        }

        static Int32 Main(string[] args)
        {
            try
            {
                Program p = new Program();
                p.ParseArguments(args);
                p.Run();
                return 0;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return -1;
            }
        }
    }
}