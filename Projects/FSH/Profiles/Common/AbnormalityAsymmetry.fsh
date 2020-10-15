Profile: AbnormalityAsymmetry
Parent: Observation
Title: "Asymmetry"
Description: """
    Asymmetry
    """
  * code = ObservationCodesCS#abnormalityAsymmetryObservation
  
  // -----------------------------------------
  // Graph Macros
  // -----------------------------------------
  * component ^slicing.discriminator.type = #pattern
  * component ^slicing.discriminator.path = "code"
  * component ^slicing.rules = #open
  * component ^slicing.ordered = false
  * component ^slicing.description = "Component slicing"

  // -----------------------------------------
  // Graph Macros
  // -----------------------------------------
  * component contains asymmetryType 1..1
  * component[asymmetryType] ^short = "Asymmetry Type component."
  * component[asymmetryType] ^comment = """
    This is one component of a group of components that are part of the observation.
    """
  * component[asymmetryType] ^definition = """
    This slice contains the optional component that refine the asymmetry type.
    The value of this component is a codeable concept chosen from the AbnormalityAsymmetryTypeVS valueset.
    """
  * component[asymmetryType].code 1..1
  * component[asymmetryType].code ^short = "Asymmetry Type component code."
  * component[asymmetryType].code ^definition = """
    This code identifies the Asymmetry Type component.
	"""
  * component[asymmetryType].code = ObservationComponentSliceCodesCS#abnormalityAsymmetryType

  // -----------------------------------------
  // Graph Macros
  // -----------------------------------------
  * component[asymmetryType].value[x] 1..1
  * component[asymmetryType].value[x] only CodeableConcept
  * component[asymmetryType].value[x] from AbnormalityAsymmetryTypeVS

  // -----------------------------------------
  // Graph Macros
  // -----------------------------------------
  * category ^slicing.discriminator.type = #pattern
  * category ^slicing.discriminator.path = "$this"
  * category ^slicing.rules = #open
  * category ^slicing.ordered = false
  * category ^slicing.description = "Observation Category = imaging"
  * category contains categoryImaging 1..1
  * category[categoryImaging] = http://terminology.hl7.org/CodeSystem/observation-category#imaging
  * interpretation 0..0
  * referenceRange 0..0
  * basedOn 0..0
  * partOf 0..0
  * focus 0..0
  * specimen 0..0
  * contained 0..0
  * device 0..0
  * dataAbsentReason 0..0
  * value[x] 0..0
  * interpretation 0..0
  * referenceRange 0..0
  * bodySite 1..1
  * bodySite.extension contains BreastBodyLocationExtension named breastBodyLocation 1..1
  * bodySite.extension[breastBodyLocation] ^short = "breastBodyLocation extension."
  * bodySite.extension[breastBodyLocation] ^definition = "This extension slice contains the breastBodyLocation extension."

  // -----------------------------------------
  // Graph Macros
  // -----------------------------------------
  * component contains obsChanges 0..*
  * component[obsChanges] ^short = "Observed Change In Abnormality component."
  * component[obsChanges] ^comment = """
    This is one component of a group of components that are part of the observation.
    """
  * component[obsChanges] ^definition = """
    This slice contains the optional components that define observed changes in this abnormality.
    The value of this component is a codeable concept chosen from the ObservedChangesVS valueset.
    """
  * component[obsChanges].code 1..1
  * component[obsChanges].code ^short = "Observed Change In Abnormality component code."
  * component[obsChanges].code ^definition = """
    This code identifies the Observed Change In Abnormality component.
	"""
  * component[obsChanges].code = ObservationComponentSliceCodesCS#obsChanges

  // -----------------------------------------
  // Graph Macros
  // -----------------------------------------
  * component[obsChanges].value[x] 1..1
  * component[obsChanges].value[x] only CodeableConcept
  * component[obsChanges].value[x] from ObservedChangesVS

  // -----------------------------------------
  // Graph Macros
  // -----------------------------------------

  // -----------------------------------------
  // Graph Macros
  // -----------------------------------------
  * component contains biRadsAssessmentCategory 0..1
  * component[biRadsAssessmentCategory] ^short = "BiRads Assessment Category component. component."
  * component[biRadsAssessmentCategory] ^comment = """
    This is one component of a group of components that are part of the observation.
    """
  * component[biRadsAssessmentCategory] ^definition = """
    This slice contains the optional component that define the BiRAD risk code.
    The value of this component is a codeable concept chosen from the BiRadsAssessmentCategoriesVS valueset.
    """
  * component[biRadsAssessmentCategory].code 1..1
  * component[biRadsAssessmentCategory].code ^short = "BiRads Assessment Category component. component code."
  * component[biRadsAssessmentCategory].code ^definition = """
    This code identifies the BiRads Assessment Category component. component.
	"""
  * component[biRadsAssessmentCategory].code = ObservationComponentSliceCodesCS#targetBiRads

  // -----------------------------------------
  // Graph Macros
  // -----------------------------------------
  * component[biRadsAssessmentCategory].value[x] 1..1
  * component[biRadsAssessmentCategory].value[x] only CodeableConcept
  * component[biRadsAssessmentCategory].value[x] from BiRadsAssessmentCategoryVS

  // -----------------------------------------
  // Graph Macros
  // -----------------------------------------

  // -----------------------------------------
  // Graph Macros
  // -----------------------------------------
  // Define Orientation Slice
  * component contains orientation 0..1
  * component[orientation] ^short = "Orientation component."
  * component[orientation] ^comment = """
    This is one component of a group of components that are part of the observation.
    """
  * component[orientation] ^definition = """
    This slice contains the optional component that define the orientation of the abnormality.
    The value of this component is a codeable concept chosen from the OrientationVS valueset.
    """
  * component[orientation].code 1..1
  * component[orientation].code ^short = "Orientation component code."
  * component[orientation].code ^definition = """
    This code identifies the Orientation component.
	"""
  * component[orientation].code = ObservationComponentSliceCodesCS#orientation

  // -----------------------------------------
  // Graph Macros
  // -----------------------------------------
  * component[orientation].value[x] 1..1
  * component[orientation].value[x] only CodeableConcept
  * component[orientation].value[x] from OrientationVS

  // -----------------------------------------
  // Graph Macros
  // -----------------------------------------
  // Define Shape Slice
  * component contains shape 0..1
  * component[shape] ^short = "Shape component."
  * component[shape] ^comment = """
    This is one component of a group of components that are part of the observation.
    """
  * component[shape] ^definition = """
    This slice contains the optional component that define the shape of the abnormality.
    The value of this component is a codeable concept chosen from the ShapeVS valueset.
    """
  * component[shape].code 1..1
  * component[shape].code ^short = "Shape component code."
  * component[shape].code ^definition = """
    This code identifies the Shape component.
	"""
  * component[shape].code = ObservationComponentSliceCodesCS#shape

  // -----------------------------------------
  // Graph Macros
  // -----------------------------------------
  * component[shape].value[x] 1..1
  * component[shape].value[x] only CodeableConcept
  * component[shape].value[x] from ShapeVS

  // -----------------------------------------
  // Graph Macros
  // -----------------------------------------
  // Define Margin Slice
  * component contains margin 0..1
  * component[margin] ^short = "Margin component."
  * component[margin] ^comment = """
    This is one component of a group of components that are part of the observation.
    """
  * component[margin] ^definition = """
    This slice contains the optional component that define the margin of the abnormality.
    The value of this component is a codeable concept chosen from the MarginVS valueset.
    """
  * component[margin].code 1..1
  * component[margin].code ^short = "Margin component code."
  * component[margin].code ^definition = """
    This code identifies the Margin component.
	"""
  * component[margin].code = ObservationComponentSliceCodesCS#margin

  // -----------------------------------------
  // Graph Macros
  // -----------------------------------------
  * component[margin].value[x] 1..1
  * component[margin].value[x] only CodeableConcept
  * component[margin].value[x] from MarginVS

  // -----------------------------------------
  // Graph Macros
  // -----------------------------------------
  // Define Breast Density
  * component contains mgBreastDensity 0..1
  * component[mgBreastDensity] ^short = "Density component."
  * component[mgBreastDensity] ^comment = """
    This is one component of a group of components that are part of the observation.
    """
  * component[mgBreastDensity] ^definition = """
    This slice contains the optional component that define the 
    observed density of the breast tissue.
    The value of this component is a codeable concept chosen from the MarginVS valueset.
    """
  * component[mgBreastDensity].code 1..1
  * component[mgBreastDensity].code ^short = "Density component code."
  * component[mgBreastDensity].code ^definition = """
    This code identifies the Density component.
	"""
  * component[mgBreastDensity].code = ObservationComponentSliceCodesCS#mgBreastDensity

  // -----------------------------------------
  // Graph Macros
  // -----------------------------------------
  * component[mgBreastDensity].value[x] 1..1
  * component[mgBreastDensity].value[x] only CodeableConcept
  * component[mgBreastDensity].value[x] from MGBreastDensityVS

  // -----------------------------------------
  // Graph Macros
  // -----------------------------------------

  // -----------------------------------------
  // Graph Macros
  // -----------------------------------------
  * component contains notPreviouslySeen 0..*
  * component[notPreviouslySeen] ^short = "Not Previously Seen component."
  * component[notPreviouslySeen] ^comment = """
    This is one component of a group of components that are part of the observation.
    """
  * component[notPreviouslySeen] ^definition = """
    This slice contains the optional components that define prevous encounters in which this abnormality was not seen.
    The value of this component is a codeable concept chosen from the NotPreviouslySeenVS valueset.
    """
  * component[notPreviouslySeen].code 1..1
  * component[notPreviouslySeen].code ^short = "Not Previously Seen component code."
  * component[notPreviouslySeen].code ^definition = """
    This code identifies the Not Previously Seen component.
	"""
  * component[notPreviouslySeen].code = ObservationComponentSliceCodesCS#notPreviouslySeen

  // -----------------------------------------
  // Graph Macros
  // -----------------------------------------
  * component[notPreviouslySeen].value[x] 1..1
  * component[notPreviouslySeen].value[x] only CodeableConcept
  * component[notPreviouslySeen].value[x] from NotPreviouslySeenVS

  // -----------------------------------------
  // Graph Macros
  // -----------------------------------------

  // -----------------------------------------
  // Graph Macros
  // -----------------------------------------
  * component contains observedCount 0..1
  * component[observedCount] ^short = "Observed Count component. component."
  * component[observedCount] ^comment = """
    This is one component of a group of components that are part of the observation.
    """
  * component[observedCount] ^definition = """
      This component slice contains the number of items observed.
    This can be a quantity (i.e. 5), or a range (1 to 5).
    
    If the lower bound of the range is set but not the upper bound,
    then it means {lower bound} or more.
    
    If the lower bound of the range is not set but the upper bound is,
    then it means {upper bound} or less.
    """
  * component[observedCount].code 1..1
  * component[observedCount].code ^short = "Observed Count component. component code."
  * component[observedCount].code ^definition = """
    This code identifies the Observed Count component. component.
	"""
  * component[observedCount].code = ObservationComponentSliceCodesCS#obsCount

  // -----------------------------------------
  // Graph Macros
  // -----------------------------------------
  * component[observedCount].value[x] 1..1
  * component[observedCount].value[x] only Quantity or Range

  // -----------------------------------------
  // Graph Macros
  // -----------------------------------------
  * component contains correspondsWith 0..*
  * component[correspondsWith] ^short = "Abnormality Corresponds With component."
  * component[correspondsWith] ^comment = """
    This is one component of a group of components that are part of the observation.
    """
  * component[correspondsWith] ^definition = """
    This slice contains the optional components that define what this observation corresponds with.
    The value of this component is a codeable concept chosen from the CorrespondsWithVS valueset.
    """
  * component[correspondsWith].code 1..1
  * component[correspondsWith].code ^short = "Abnormality Corresponds With component code."
  * component[correspondsWith].code ^definition = """
    This code identifies the Abnormality Corresponds With component.
	"""
  * component[correspondsWith].code = ObservationComponentSliceCodesCS#correspondsWith

  // -----------------------------------------
  // Graph Macros
  // -----------------------------------------
  * component[correspondsWith].value[x] 1..1
  * component[correspondsWith].value[x] only CodeableConcept
  * component[correspondsWith].value[x] from CorrespondsWithVS

  // -----------------------------------------
  // Graph Macros
  // -----------------------------------------

  // -----------------------------------------
  // Graph Macros
  // -----------------------------------------
  * component contains prevDemBy 0..*
  * component[prevDemBy] ^short = "Previously Demonstrated by component."
  * component[prevDemBy] ^comment = """
    This is one component of a group of components that are part of the observation.
    """
  * component[prevDemBy] ^definition = """
    This slice contains the optional components that specifies what this observation 
    has been previously demonstrated by.
    The value of this component is a codeable concept chosen from the 
    PreviouslyDemonstratedByVS valueset.  
    """
  * component[prevDemBy].code 1..1
  * component[prevDemBy].code ^short = "Previously Demonstrated by component code."
  * component[prevDemBy].code ^definition = """
    This code identifies the Previously Demonstrated by component.
	"""
  * component[prevDemBy].code = ObservationComponentSliceCodesCS#prevDemBy

  // -----------------------------------------
  // Graph Macros
  // -----------------------------------------
  * component[prevDemBy].value[x] 1..1
  * component[prevDemBy].value[x] only CodeableConcept
  * component[prevDemBy].value[x] from PreviouslyDemonstratedByVS

  // -----------------------------------------
  // Graph Macros
  // -----------------------------------------

  // -----------------------------------------
  // Graph Macros
  // -----------------------------------------
  * hasMember ^slicing.discriminator.type = #value
  * hasMember ^slicing.discriminator.path = "url"
  * hasMember ^slicing.rules = #open
  * hasMember ^slicing.ordered = false
  * hasMember ^slicing.description = "Component slicing"

  // -----------------------------------------
  // Graph Macros
  // -----------------------------------------
  * hasMember contains associatedFeature 0..*
  * hasMember[associatedFeature] ^short = "'Associated Feature' reference. hasMember."
  * hasMember[associatedFeature] only Reference(AssociatedFeature)

  // -----------------------------------------
  // Graph Macros
  // -----------------------------------------
  
  // -----------------------------------------
  // Graph Macros
  // -----------------------------------------
  * hasMember contains consistentWith 0..*
  * hasMember[consistentWith] ^short = "'Consistent With' reference. hasMember."
  * hasMember[consistentWith] only Reference(ConsistentWith)

  // -----------------------------------------
  // Graph Macros
  // -----------------------------------------

  // -----------------------------------------
  // Graph Macros
  // -----------------------------------------

  // -----------------------------------------
  // Graph Macros
  // -----------------------------------------