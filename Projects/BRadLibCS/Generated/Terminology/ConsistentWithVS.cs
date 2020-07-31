using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace BRadLibCS
{
	public class ConsistentWithVS
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
		public const String Url = "http://hl7.org/fhir/us/breast-radiology/ValueSet/ConsistentWithVS";

		public static TCoding Code_Abscess = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ConsistentWithCS", "Abscess"));// CSItemValueSet.cs:78
		public static TCoding Code_Angiolipoma = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ConsistentWithCS", "Angiolipoma"));// CSItemValueSet.cs:78
		public static TCoding Code_ApocrineMetaplasia = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ConsistentWithCS", "ApocrineMetaplasia"));// CSItemValueSet.cs:78
		public static TCoding Code_Artifact = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ConsistentWithCS", "Artifact"));// CSItemValueSet.cs:78
		public static TCoding Code_AtypicalHyperplasia = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ConsistentWithCS", "AtypicalHyperplasia"));// CSItemValueSet.cs:78
		public static TCoding Code_AxillaryLymphNode = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ConsistentWithCS", "AxillaryLymphNode"));// CSItemValueSet.cs:78
		public static TCoding Code_Carcinoma = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ConsistentWithCS", "Carcinoma"));// CSItemValueSet.cs:78
		public static TCoding Code_CarcinomaKnown = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ConsistentWithCS", "CarcinomaKnown"));// CSItemValueSet.cs:78
		public static TCoding Code_ClusterOfCysts = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ConsistentWithCS", "ClusterOfCysts"));// CSItemValueSet.cs:78
		public static TCoding Code_Cyst = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ConsistentWithCS", "Cyst")); // CSItemValueSet.cs:78
		public static TCoding Code_CystComplex = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ConsistentWithCS", "CystComplex"));// CSItemValueSet.cs:78
		public static TCoding Code_CystComplicated = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ConsistentWithCS", "CystComplicated"));// CSItemValueSet.cs:78
		public static TCoding Code_CystOil = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ConsistentWithCS", "CystOil"));// CSItemValueSet.cs:78
		public static TCoding Code_CystSebaceous = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ConsistentWithCS", "CystSebaceous"));// CSItemValueSet.cs:78
		public static TCoding Code_CystSimple = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ConsistentWithCS", "CystSimple"));// CSItemValueSet.cs:78
		public static TCoding Code_CystsComplex = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ConsistentWithCS", "CystsComplex"));// CSItemValueSet.cs:78
		public static TCoding Code_CystsComplicated = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ConsistentWithCS", "CystsComplicated"));// CSItemValueSet.cs:78
		public static TCoding Code_CystsMicroClustered = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ConsistentWithCS", "CystsMicroClustered"));// CSItemValueSet.cs:78
		public static TCoding Code_DCIS = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ConsistentWithCS", "DCIS")); // CSItemValueSet.cs:78
		public static TCoding Code_Debris = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ConsistentWithCS", "Debris"));// CSItemValueSet.cs:78
		public static TCoding Code_Deodorant = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ConsistentWithCS", "Deodorant"));// CSItemValueSet.cs:78
		public static TCoding Code_DermalCalcification = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ConsistentWithCS", "DermalCalcification"));// CSItemValueSet.cs:78
		public static TCoding Code_DuctEctasia = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ConsistentWithCS", "DuctEctasia"));// CSItemValueSet.cs:78
		public static TCoding Code_Edema = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ConsistentWithCS", "Edema"));// CSItemValueSet.cs:78
		public static TCoding Code_FatLobule = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ConsistentWithCS", "FatLobule"));// CSItemValueSet.cs:78
		public static TCoding Code_FatNecrosis = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ConsistentWithCS", "FatNecrosis"));// CSItemValueSet.cs:78
		public static TCoding Code_Fibroadenolipoma = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ConsistentWithCS", "Fibroadenolipoma"));// CSItemValueSet.cs:78
		public static TCoding Code_Fibroadenoma = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ConsistentWithCS", "Fibroadenoma"));// CSItemValueSet.cs:78
		public static TCoding Code_FibroadenomaDegenerating = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ConsistentWithCS", "FibroadenomaDegenerating"));// CSItemValueSet.cs:78
		public static TCoding Code_FibrocysticChange = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ConsistentWithCS", "FibrocysticChange"));// CSItemValueSet.cs:78
		public static TCoding Code_FibroglandularTissue = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ConsistentWithCS", "FibroglandularTissue"));// CSItemValueSet.cs:78
		public static TCoding Code_Fibrosis = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ConsistentWithCS", "Fibrosis"));// CSItemValueSet.cs:78
		public static TCoding Code_FibrousRidge = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ConsistentWithCS", "FibrousRidge"));// CSItemValueSet.cs:78
		public static TCoding Code_Folliculitis = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ConsistentWithCS", "Folliculitis"));// CSItemValueSet.cs:78
		public static TCoding Code_Gynecomastia = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ConsistentWithCS", "Gynecomastia"));// CSItemValueSet.cs:78
		public static TCoding Code_Hamartoma = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ConsistentWithCS", "Hamartoma"));// CSItemValueSet.cs:78
		public static TCoding Code_Hematoma = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ConsistentWithCS", "Hematoma"));// CSItemValueSet.cs:78
		public static TCoding Code_HormonalStimulation = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ConsistentWithCS", "HormonalStimulation"));// CSItemValueSet.cs:78
		public static TCoding Code_IntracysticLesion = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ConsistentWithCS", "IntracysticLesion"));// CSItemValueSet.cs:78
		public static TCoding Code_IntramammaryNode = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ConsistentWithCS", "IntramammaryNode"));// CSItemValueSet.cs:78
		public static TCoding Code_Lipoma = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ConsistentWithCS", "Lipoma"));// CSItemValueSet.cs:78
		public static TCoding Code_LumpectomyCavity = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ConsistentWithCS", "LumpectomyCavity"));// CSItemValueSet.cs:78
		public static TCoding Code_LumpectomySite = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ConsistentWithCS", "LumpectomySite"));// CSItemValueSet.cs:78
		public static TCoding Code_LymphNode = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ConsistentWithCS", "LymphNode"));// CSItemValueSet.cs:78
		public static TCoding Code_LymphNodeEnlarged = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ConsistentWithCS", "LymphNodeEnlarged"));// CSItemValueSet.cs:78
		public static TCoding Code_LymphNodeNormal = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ConsistentWithCS", "LymphNodeNormal"));// CSItemValueSet.cs:78
		public static TCoding Code_LymphNodePathological = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ConsistentWithCS", "LymphNodePathological"));// CSItemValueSet.cs:78
		public static TCoding Code_MassSolid = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ConsistentWithCS", "MassSolid"));// CSItemValueSet.cs:78
		public static TCoding Code_MassSolidWTumorVasc = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ConsistentWithCS", "MassSolidW/tumorVasc"));// CSItemValueSet.cs:78
		public static TCoding Code_Mastitis = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ConsistentWithCS", "Mastitis"));// CSItemValueSet.cs:78
		public static TCoding Code_MilkOfCalcium = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ConsistentWithCS", "MilkOfCalcium"));// CSItemValueSet.cs:78
		public static TCoding Code_MultiFocalCancer = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ConsistentWithCS", "Multi-focalCancer"));// CSItemValueSet.cs:78
		public static TCoding Code_PapillaryLesion = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ConsistentWithCS", "PapillaryLesion"));// CSItemValueSet.cs:78
		public static TCoding Code_Papilloma = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ConsistentWithCS", "Papilloma"));// CSItemValueSet.cs:78
		public static TCoding Code_PhyllodesTumor = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ConsistentWithCS", "PhyllodesTumor"));// CSItemValueSet.cs:78
		public static TCoding Code_PostLumpectomyScar = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ConsistentWithCS", "PostLumpectomyScar"));// CSItemValueSet.cs:78
		public static TCoding Code_PostSurgicalScar = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ConsistentWithCS", "PostSurgicalScar"));// CSItemValueSet.cs:78
		public static TCoding Code_PreviousBiopsy = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ConsistentWithCS", "PreviousBiopsy"));// CSItemValueSet.cs:78
		public static TCoding Code_PreviousSurgery = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ConsistentWithCS", "PreviousSurgery"));// CSItemValueSet.cs:78
		public static TCoding Code_PreviousTrauma = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ConsistentWithCS", "PreviousTrauma"));// CSItemValueSet.cs:78
		public static TCoding Code_RadialScar = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ConsistentWithCS", "RadialScar"));// CSItemValueSet.cs:78
		public static TCoding Code_RadiationChanges = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ConsistentWithCS", "RadiationChanges"));// CSItemValueSet.cs:78
		public static TCoding Code_RadiationTherapy = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ConsistentWithCS", "RadiationTherapy"));// CSItemValueSet.cs:78
		public static TCoding Code_Scar = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ConsistentWithCS", "Scar")); // CSItemValueSet.cs:78
		public static TCoding Code_ScarWithShadowing = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ConsistentWithCS", "ScarWithShadowing"));// CSItemValueSet.cs:78
		public static TCoding Code_SclerosingAdenosis = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ConsistentWithCS", "SclerosingAdenosis"));// CSItemValueSet.cs:78
		public static TCoding Code_SecretoryCalcification = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ConsistentWithCS", "SecretoryCalcification"));// CSItemValueSet.cs:78
		public static TCoding Code_SentinelNode = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ConsistentWithCS", "SentinelNode"));// CSItemValueSet.cs:78
		public static TCoding Code_Seroma = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ConsistentWithCS", "Seroma"));// CSItemValueSet.cs:78
		public static TCoding Code_SkinLesion = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ConsistentWithCS", "SkinLesion"));// CSItemValueSet.cs:78
		public static TCoding Code_Surgery = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ConsistentWithCS", "Surgery"));// CSItemValueSet.cs:78
		public static TCoding Code_Trauma = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ConsistentWithCS", "Trauma"));// CSItemValueSet.cs:78
		public static TCoding Code_VascularCalcifications = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ConsistentWithCS", "VascularCalcifications"));// CSItemValueSet.cs:78
		public static TCoding Code_VenousStasis = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ConsistentWithCS", "VenousStasis"));// CSItemValueSet.cs:78

		public static IEnumerable<TCoding> Codes()                                                                                                // CSItemValueSet.cs:57
		{                                                                                                                                         // CSItemValueSet.cs:58
		    yield return Code_Abscess;                                                                                                            // CSItemValueSet.cs:83
		    yield return Code_Angiolipoma;                                                                                                        // CSItemValueSet.cs:83
		    yield return Code_ApocrineMetaplasia;                                                                                                 // CSItemValueSet.cs:83
		    yield return Code_Artifact;                                                                                                           // CSItemValueSet.cs:83
		    yield return Code_AtypicalHyperplasia;                                                                                                // CSItemValueSet.cs:83
		    yield return Code_AxillaryLymphNode;                                                                                                  // CSItemValueSet.cs:83
		    yield return Code_Carcinoma;                                                                                                          // CSItemValueSet.cs:83
		    yield return Code_CarcinomaKnown;                                                                                                     // CSItemValueSet.cs:83
		    yield return Code_ClusterOfCysts;                                                                                                     // CSItemValueSet.cs:83
		    yield return Code_Cyst;                                                                                                               // CSItemValueSet.cs:83
		    yield return Code_CystComplex;                                                                                                        // CSItemValueSet.cs:83
		    yield return Code_CystComplicated;                                                                                                    // CSItemValueSet.cs:83
		    yield return Code_CystOil;                                                                                                            // CSItemValueSet.cs:83
		    yield return Code_CystSebaceous;                                                                                                      // CSItemValueSet.cs:83
		    yield return Code_CystSimple;                                                                                                         // CSItemValueSet.cs:83
		    yield return Code_CystsComplex;                                                                                                       // CSItemValueSet.cs:83
		    yield return Code_CystsComplicated;                                                                                                   // CSItemValueSet.cs:83
		    yield return Code_CystsMicroClustered;                                                                                                // CSItemValueSet.cs:83
		    yield return Code_DCIS;                                                                                                               // CSItemValueSet.cs:83
		    yield return Code_Debris;                                                                                                             // CSItemValueSet.cs:83
		    yield return Code_Deodorant;                                                                                                          // CSItemValueSet.cs:83
		    yield return Code_DermalCalcification;                                                                                                // CSItemValueSet.cs:83
		    yield return Code_DuctEctasia;                                                                                                        // CSItemValueSet.cs:83
		    yield return Code_Edema;                                                                                                              // CSItemValueSet.cs:83
		    yield return Code_FatLobule;                                                                                                          // CSItemValueSet.cs:83
		    yield return Code_FatNecrosis;                                                                                                        // CSItemValueSet.cs:83
		    yield return Code_Fibroadenolipoma;                                                                                                   // CSItemValueSet.cs:83
		    yield return Code_Fibroadenoma;                                                                                                       // CSItemValueSet.cs:83
		    yield return Code_FibroadenomaDegenerating;                                                                                           // CSItemValueSet.cs:83
		    yield return Code_FibrocysticChange;                                                                                                  // CSItemValueSet.cs:83
		    yield return Code_FibroglandularTissue;                                                                                               // CSItemValueSet.cs:83
		    yield return Code_Fibrosis;                                                                                                           // CSItemValueSet.cs:83
		    yield return Code_FibrousRidge;                                                                                                       // CSItemValueSet.cs:83
		    yield return Code_Folliculitis;                                                                                                       // CSItemValueSet.cs:83
		    yield return Code_Gynecomastia;                                                                                                       // CSItemValueSet.cs:83
		    yield return Code_Hamartoma;                                                                                                          // CSItemValueSet.cs:83
		    yield return Code_Hematoma;                                                                                                           // CSItemValueSet.cs:83
		    yield return Code_HormonalStimulation;                                                                                                // CSItemValueSet.cs:83
		    yield return Code_IntracysticLesion;                                                                                                  // CSItemValueSet.cs:83
		    yield return Code_IntramammaryNode;                                                                                                   // CSItemValueSet.cs:83
		    yield return Code_Lipoma;                                                                                                             // CSItemValueSet.cs:83
		    yield return Code_LumpectomyCavity;                                                                                                   // CSItemValueSet.cs:83
		    yield return Code_LumpectomySite;                                                                                                     // CSItemValueSet.cs:83
		    yield return Code_LymphNode;                                                                                                          // CSItemValueSet.cs:83
		    yield return Code_LymphNodeEnlarged;                                                                                                  // CSItemValueSet.cs:83
		    yield return Code_LymphNodeNormal;                                                                                                    // CSItemValueSet.cs:83
		    yield return Code_LymphNodePathological;                                                                                              // CSItemValueSet.cs:83
		    yield return Code_MassSolid;                                                                                                          // CSItemValueSet.cs:83
		    yield return Code_MassSolidWTumorVasc;                                                                                                // CSItemValueSet.cs:83
		    yield return Code_Mastitis;                                                                                                           // CSItemValueSet.cs:83
		    yield return Code_MilkOfCalcium;                                                                                                      // CSItemValueSet.cs:83
		    yield return Code_MultiFocalCancer;                                                                                                   // CSItemValueSet.cs:83
		    yield return Code_PapillaryLesion;                                                                                                    // CSItemValueSet.cs:83
		    yield return Code_Papilloma;                                                                                                          // CSItemValueSet.cs:83
		    yield return Code_PhyllodesTumor;                                                                                                     // CSItemValueSet.cs:83
		    yield return Code_PostLumpectomyScar;                                                                                                 // CSItemValueSet.cs:83
		    yield return Code_PostSurgicalScar;                                                                                                   // CSItemValueSet.cs:83
		    yield return Code_PreviousBiopsy;                                                                                                     // CSItemValueSet.cs:83
		    yield return Code_PreviousSurgery;                                                                                                    // CSItemValueSet.cs:83
		    yield return Code_PreviousTrauma;                                                                                                     // CSItemValueSet.cs:83
		    yield return Code_RadialScar;                                                                                                         // CSItemValueSet.cs:83
		    yield return Code_RadiationChanges;                                                                                                   // CSItemValueSet.cs:83
		    yield return Code_RadiationTherapy;                                                                                                   // CSItemValueSet.cs:83
		    yield return Code_Scar;                                                                                                               // CSItemValueSet.cs:83
		    yield return Code_ScarWithShadowing;                                                                                                  // CSItemValueSet.cs:83
		    yield return Code_SclerosingAdenosis;                                                                                                 // CSItemValueSet.cs:83
		    yield return Code_SecretoryCalcification;                                                                                             // CSItemValueSet.cs:83
		    yield return Code_SentinelNode;                                                                                                       // CSItemValueSet.cs:83
		    yield return Code_Seroma;                                                                                                             // CSItemValueSet.cs:83
		    yield return Code_SkinLesion;                                                                                                         // CSItemValueSet.cs:83
		    yield return Code_Surgery;                                                                                                            // CSItemValueSet.cs:83
		    yield return Code_Trauma;                                                                                                             // CSItemValueSet.cs:83
		    yield return Code_VascularCalcifications;                                                                                             // CSItemValueSet.cs:83
		    yield return Code_VenousStasis;                                                                                                       // CSItemValueSet.cs:83
		}                                                                                                                                         // CSItemValueSet.cs:104
	}
}
