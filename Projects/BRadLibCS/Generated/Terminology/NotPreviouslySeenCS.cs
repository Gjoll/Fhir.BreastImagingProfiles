using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace BreastRadLib
{
	public class NotPreviouslySeenCS
	{
		/// <summary>
		/// Code Set System.
		/// </summary>
		public const String System = "http://hl7.org/fhir/us/breast-radiology/CodeSystem/NotPreviouslySeenCS";

		public static Coding Code_ClinicalExam = new Coding(System, "ClinicalExam", "Clinical exam");                                             // CSItemCodeSystem.cs:62
		public static Coding Code_Ductogram = new Coding(System, "Ductogram", "Ductogram");                                                       // CSItemCodeSystem.cs:62
		public static Coding Code_Mammogram = new Coding(System, "Mammogram", "Mammogram");                                                       // CSItemCodeSystem.cs:62
		public static Coding Code_MRI = new Coding(System, "MRI", "MRI");                                                                         // CSItemCodeSystem.cs:62
		public static Coding Code_OutsideExam = new Coding(System, "OutsideExam", "Outside exam");                                                // CSItemCodeSystem.cs:62
		public static Coding Code_Scintimammography = new Coding(System, "Scintimammography", "Scintimammography");                               // CSItemCodeSystem.cs:62
		public static Coding Code_Ultrasound = new Coding(System, "Ultrasound", "Ultrasound");                                                    // CSItemCodeSystem.cs:62

		public static IEnumerable<Coding> Codes()                                                                                                 // CSItemCodeSystem.cs:54
		{                                                                                                                                         // CSItemCodeSystem.cs:55
		    yield return Code_ClinicalExam;                                                                                                       // CSItemCodeSystem.cs:65
		    yield return Code_Ductogram;                                                                                                          // CSItemCodeSystem.cs:65
		    yield return Code_Mammogram;                                                                                                          // CSItemCodeSystem.cs:65
		    yield return Code_MRI;                                                                                                                // CSItemCodeSystem.cs:65
		    yield return Code_OutsideExam;                                                                                                        // CSItemCodeSystem.cs:65
		    yield return Code_Scintimammography;                                                                                                  // CSItemCodeSystem.cs:65
		    yield return Code_Ultrasound;                                                                                                         // CSItemCodeSystem.cs:65
		}                                                                                                                                         // CSItemCodeSystem.cs:70
	}
}