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
    /*
	 All code in this class is automatically generated.
	 */

	/// <summary>
	/// Interface IAbnormalityArchitecturalDistortion.
	/// </summary>
	public interface IAbnormalityArchitecturalDistortion  : IBreastBodyLocationRequiredFragment,
        IObservedChangesFragment,
        IBiRadFragment,
        IShapeFragment,
        INotPreviouslySeenFragment,
        ICorrespondsWithFragment,
        IPreviouslyDemonstratedByFragment,
        IAssociatedFeatureFragment,
        IConsistentWithFragment
	{

	}

	/// <summary>
	/// class CAbnormalityArchitecturalDistortionProfile.
	/// </summary>
	public partial class AbnormalityArchitecturalDistortionProfile :  ObservationBase, IAbnormalityArchitecturalDistortion
	{
		public ObservationHasMemberCollection<AssociatedFeatureProfile> AssociatedFeature { get; set; }                                           // CSHasMemberSlice.cs:91
		public ObservationHasMemberCollection<ConsistentWithProfile> ConsistentWith { get; set; }                                                 // CSHasMemberSlice.cs:91
		public ObservationComponentItem<CodeableConcept> ObsChanges { get; set; }                                                                 // CSComponentSlice.cs:105
		public ObservationComponentItem<CodeableConcept> BiRadsAssessmentCategory { get; set; }                                                   // CSComponentSlice.cs:105
		public ObservationComponentItem<CodeableConcept> Orientation { get; set; }                                                                // CSComponentSlice.cs:105
		public ObservationComponentItem<CodeableConcept> Shape { get; set; }                                                                      // CSComponentSlice.cs:105
		public ObservationComponentItem<CodeableConcept> Margin { get; set; }                                                                     // CSComponentSlice.cs:105
		public ObservationComponentItem<CodeableConcept> MgBreastDensity { get; set; }                                                            // CSComponentSlice.cs:105
		public ObservationComponentItem<CodeableConcept> NotPreviouslySeen { get; set; }                                                          // CSComponentSlice.cs:105
		public ObservationComponentItem<CodeableConcept> CorrespondsWith { get; set; }                                                            // CSComponentSlice.cs:105
		public ObservationComponentItem<CodeableConcept> PrevDemBy { get; set; }                                                                  // CSComponentSlice.cs:105

		/// <summary>
		/// Constructor.
		/// Caller must call Init();
		/// </summary>
		public AbnormalityArchitecturalDistortionProfile(BreastRadiologyDocument doc) : base(doc)
		{
		    this.Init();
		}

		/// <summary>
		/// Init object.
		/// </summary>
		protected override void Init()
		{
		    base.Init();
			((IBreastBodyLocationRequiredFragment)this).Init();                                                                                      // CSItemClass.cs:75
			((IObservedChangesFragment)this).Init();                                                                                                 // CSItemClass.cs:75
			((IBiRadFragment)this).Init();                                                                                                           // CSItemClass.cs:75
			((IShapeFragment)this).Init();                                                                                                           // CSItemClass.cs:75
			((INotPreviouslySeenFragment)this).Init();                                                                                               // CSItemClass.cs:75
			((ICorrespondsWithFragment)this).Init();                                                                                                 // CSItemClass.cs:75
			((IPreviouslyDemonstratedByFragment)this).Init();                                                                                        // CSItemClass.cs:75
			((IAssociatedFeatureFragment)this).Init();                                                                                               // CSItemClass.cs:75
			((IConsistentWithFragment)this).Init();                                                                                                  // CSItemClass.cs:75
		}

		/// <summary>
		/// Validate object. Will return false if an error is detected. sb will contains text of error found.
		/// User must not call Init().
		/// </summary>
		public override bool Validate(StringBuilder sb)
		{
			bool retVal = true;
			if (base.Validate(sb) == false)
				retVal = false;
			((IBreastBodyLocationRequiredFragment)this).Validate(sb);                                                                                // CSItemClass.cs:84
			((IObservedChangesFragment)this).Validate(sb);                                                                                           // CSItemClass.cs:84
			((IBiRadFragment)this).Validate(sb);                                                                                                     // CSItemClass.cs:84
			((IShapeFragment)this).Validate(sb);                                                                                                     // CSItemClass.cs:84
			((INotPreviouslySeenFragment)this).Validate(sb);                                                                                         // CSItemClass.cs:84
			((ICorrespondsWithFragment)this).Validate(sb);                                                                                           // CSItemClass.cs:84
			((IPreviouslyDemonstratedByFragment)this).Validate(sb);                                                                                  // CSItemClass.cs:84
			((IAssociatedFeatureFragment)this).Validate(sb);                                                                                         // CSItemClass.cs:84
			((IConsistentWithFragment)this).Validate(sb);                                                                                            // CSItemClass.cs:84
			return retVal;
		}

		/// <summary>
		/// Write to fhir resource
		/// </summary>
		public override void Write()
		{
			base.Write();
			((IBreastBodyLocationRequiredFragment)this).Write(this.Doc);                                                                             // CSItemClass.cs:81
			((IObservedChangesFragment)this).Write(this.Doc);                                                                                        // CSItemClass.cs:81
			((IBiRadFragment)this).Write(this.Doc);                                                                                                  // CSItemClass.cs:81
			((IShapeFragment)this).Write(this.Doc);                                                                                                  // CSItemClass.cs:81
			((INotPreviouslySeenFragment)this).Write(this.Doc);                                                                                      // CSItemClass.cs:81
			((ICorrespondsWithFragment)this).Write(this.Doc);                                                                                        // CSItemClass.cs:81
			((IPreviouslyDemonstratedByFragment)this).Write(this.Doc);                                                                               // CSItemClass.cs:81
			((IAssociatedFeatureFragment)this).Write(this.Doc);                                                                                      // CSItemClass.cs:81
			((IConsistentWithFragment)this).Write(this.Doc);                                                                                         // CSItemClass.cs:81
		}

		/// <summary>
		/// Read from fhir resource
		/// </summary>
		public override void Read()
		{
			base.Read();
			((IBreastBodyLocationRequiredFragment)this).Read(this.Doc);                                                                              // CSItemClass.cs:78
			((IObservedChangesFragment)this).Read(this.Doc);                                                                                         // CSItemClass.cs:78
			((IBiRadFragment)this).Read(this.Doc);                                                                                                   // CSItemClass.cs:78
			((IShapeFragment)this).Read(this.Doc);                                                                                                   // CSItemClass.cs:78
			((INotPreviouslySeenFragment)this).Read(this.Doc);                                                                                       // CSItemClass.cs:78
			((ICorrespondsWithFragment)this).Read(this.Doc);                                                                                         // CSItemClass.cs:78
			((IPreviouslyDemonstratedByFragment)this).Read(this.Doc);                                                                                // CSItemClass.cs:78
			((IAssociatedFeatureFragment)this).Read(this.Doc);                                                                                       // CSItemClass.cs:78
			((IConsistentWithFragment)this).Read(this.Doc);                                                                                          // CSItemClass.cs:78
		}

	}
}

