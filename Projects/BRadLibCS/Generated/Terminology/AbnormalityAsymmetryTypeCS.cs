using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace BRadLibCS
{
	public class AbnormalityAsymmetryTypeCS
	{
		/// <summary>
		/// Code Set System.
		/// </summary>
		public const String System = "http://hl7.org/fhir/us/breast-radiology/CodeSystem/AbnormalityAsymmetryTypeCS";

		public static Coding Code_Asymmetry = new Coding(System, "Asymmetry", "Asymmetry");                                                       // CSItemCodeSystem.cs:55
		public static Coding Code_AsymmetryFocal = new Coding(System, "AsymmetryFocal", "Asymmetry focal");                                       // CSItemCodeSystem.cs:55
		public static Coding Code_AsymmetryGlobal = new Coding(System, "AsymmetryGlobal", "Asymmetry global");                                    // CSItemCodeSystem.cs:55
		public static Coding Code_DevelopingAsymmetry = new Coding(System, "DevelopingAsymmetry", "Developing Asymmetry");                        // CSItemCodeSystem.cs:55

		public static IEnumerable<Coding> Codes()                                                                                                 // CSItemCodeSystem.cs:47
		{                                                                                                                                         // CSItemCodeSystem.cs:48
		    yield return Code_Asymmetry;                                                                                                          // CSItemCodeSystem.cs:58
		    yield return Code_AsymmetryFocal;                                                                                                     // CSItemCodeSystem.cs:58
		    yield return Code_AsymmetryGlobal;                                                                                                    // CSItemCodeSystem.cs:58
		    yield return Code_DevelopingAsymmetry;                                                                                                // CSItemCodeSystem.cs:58
		}                                                                                                                                         // CSItemCodeSystem.cs:63
	}
}
