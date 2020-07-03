using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace BreastRadLib
{
	public class AbnormalityCystTypeVS
	{
		/// <summary>
		/// This class creates a type for codings of this class, that implicitly converts to Coding
		/// Allows type checking for these codes.
		/// </summary>
		public class TCoding
		{
		    public Coding Value {get;}
			public static implicit operator Coding(TCoding tCode) => tCode.Value;
			public static implicit operator CodeableConcept(TCoding tCode) => new CodeableConcept(tCode.Value.System, tCode.Value.Code, tCode.Value.Display);

			public TCoding(Coding value)
		    {
		        this.Value= value;
		    }
		}

		public static TCoding Code_Cyst = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/AbnormalityCystTypeCS", "Cyst"));// CSItemValueSet.cs:66
		public static TCoding Code_CystComplex = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/AbnormalityCystTypeCS", "CystComplex"));// CSItemValueSet.cs:66
		public static TCoding Code_CystComplicated = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/AbnormalityCystTypeCS", "CystComplicated"));// CSItemValueSet.cs:66
		public static TCoding Code_CystMicro = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/AbnormalityCystTypeCS", "CystMicro"));// CSItemValueSet.cs:66
		public static TCoding Code_CystOil = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/AbnormalityCystTypeCS", "CystOil"));// CSItemValueSet.cs:66
		public static TCoding Code_CystSimple = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/AbnormalityCystTypeCS", "CystSimple"));// CSItemValueSet.cs:66
		public static TCoding Code_CystWithDebris = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/AbnormalityCystTypeCS", "CystWithDebris"));// CSItemValueSet.cs:66

		public static IEnumerable<TCoding> Codes()                                                                                                // CSItemValueSet.cs:57
		{                                                                                                                                         // CSItemValueSet.cs:58
		    yield return Code_Cyst;                                                                                                               // CSItemValueSet.cs:69
		    yield return Code_CystComplex;                                                                                                        // CSItemValueSet.cs:69
		    yield return Code_CystComplicated;                                                                                                    // CSItemValueSet.cs:69
		    yield return Code_CystMicro;                                                                                                          // CSItemValueSet.cs:69
		    yield return Code_CystOil;                                                                                                            // CSItemValueSet.cs:69
		    yield return Code_CystSimple;                                                                                                         // CSItemValueSet.cs:69
		    yield return Code_CystWithDebris;                                                                                                     // CSItemValueSet.cs:69
		}                                                                                                                                         // CSItemValueSet.cs:92
	}
}
