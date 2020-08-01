using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Range = Hl7.Fhir.Model.Range;
using Hl7.Fhir.Serialization;

namespace BRadLibCS
{
	public class ShapeVS
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

		/// <summary>
		/// Url of this value set.
		/// </summary>
		public const String Url = "http://hl7.org/fhir/us/breast-radiology/ValueSet/ShapeVS";

		public static TCoding Code_IrregularInShape = new TCoding(ShapeCS.Code_IrregularInShape);                                                 // CSItemValueSet.cs:72
		public static TCoding Code_LobulatedInShape = new TCoding(ShapeCS.Code_LobulatedInShape);                                                 // CSItemValueSet.cs:72
		public static TCoding Code_OvalInShape = new TCoding(ShapeCS.Code_OvalInShape);                                                           // CSItemValueSet.cs:72
		public static TCoding Code_Reniform = new TCoding(ShapeCS.Code_Reniform);                                                                 // CSItemValueSet.cs:72
		public static TCoding Code_RoundInShape = new TCoding(ShapeCS.Code_RoundInShape);                                                         // CSItemValueSet.cs:72

		public static IEnumerable<TCoding> Codes()                                                                                                // CSItemValueSet.cs:57
		{                                                                                                                                         // CSItemValueSet.cs:58
		    yield return Code_IrregularInShape;                                                                                                   // CSItemValueSet.cs:83
		    yield return Code_LobulatedInShape;                                                                                                   // CSItemValueSet.cs:83
		    yield return Code_OvalInShape;                                                                                                        // CSItemValueSet.cs:83
		    yield return Code_Reniform;                                                                                                           // CSItemValueSet.cs:83
		    yield return Code_RoundInShape;                                                                                                       // CSItemValueSet.cs:83
		}                                                                                                                                         // CSItemValueSet.cs:104
	}
}
