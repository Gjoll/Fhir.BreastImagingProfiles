Profile: AbnormalityFibroadenoma
Parent: Observation
Title: "Fibroadenoma"
Description: """
  Fibroadenoma
  """



  * code 1..1
  * code = ObservationCodesCS#abnormalityFibroadenomaObservation



  * component ^slicing.discriminator.type = #pattern
  * component ^slicing.discriminator.path = "code"
  * component ^slicing.rules = #open
  * component ^slicing.ordered = false
  * component ^slicing.description = "Component slicing"
  * component contains fibroAdenomaType 0..1
  * component[fibroAdenomaType] ^short = "Fibroadenoma Abnormality component."
  * component[fibroAdenomaType] ^comment = """
    This is one component of a group of components that are part of the observation.
    """
  * component[fibroAdenomaType] ^definition = """
This resource and referenced child resources contain
information about a Fibroadenoma abnormality observation
    """
  * component[fibroAdenomaType].code 1..1
  * component[fibroAdenomaType].code ^short = "Fibroadenoma Abnormality component code."
  * component[fibroAdenomaType].code ^definition = """
    This code identifies the Fibroadenoma Abnormality component.
	"""
  * component[fibroAdenomaType].code = ObservationComponentSliceCodesCS#mgAbnormalityFibroAdenomaType


  * component[fibroAdenomaType].value[x] 1..1
  * component[fibroAdenomaType].value[x] only CodeableConcept
  * component[fibroAdenomaType].value[x] from AbnormalityFibroAdenomaTypeVS

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
  // Define Observed Changes Slice
  

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


  * component[obsChanges].value[x] 1..1
  * component[obsChanges].value[x] only CodeableConcept
  * component[obsChanges].value[x] from ObservedChangesVS

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
	

  * component[biRadsAssessmentCategory].value[x] 1..1
  * component[biRadsAssessmentCategory].value[x] only CodeableConcept
  * component[biRadsAssessmentCategory].value[x] from BiRadsAssessmentCategoryVS


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


  * component[orientation].value[x] 1..1
  * component[orientation].value[x] only CodeableConcept
  * component[orientation].value[x] from OrientationVS


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


  * component[shape].value[x] 1..1
  * component[shape].value[x] only CodeableConcept
  * component[shape].value[x] from ShapeVS

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


  * component[margin].value[x] 1..1
  * component[margin].value[x] only CodeableConcept
  * component[margin].value[x] from ShapeVS

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


  * component[mgBreastDensity].value[x] 1..1
  * component[mgBreastDensity].value[x] only CodeableConcept
  * component[mgBreastDensity].value[x] from MGBreastDensityVS



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
	
  * component[observedCount].value[x] 1..1
  * component[observedCount].value[x] only Quantity or Range



  // define calcification distribution slice

  * component contains obsDistribution 0..*
  * component[obsDistribution] ^short = "Observed distribution of abnormalities component."
  * component[obsDistribution] ^comment = """
    This is one component of a group of components that are part of the observation.
    """
  * component[obsDistribution] ^definition = """
This slice contains the optional components that describe the distribution of
a group of abnormalities.
The value of this component is a codeable concept chosen from the 
CalcificationDistributionVS valueset.
    """
  * component[obsDistribution].code 1..1
  * component[obsDistribution].code ^short = "Observed distribution of abnormalities component code."
  * component[obsDistribution].code ^definition = """
    This code identifies the Observed distribution of abnormalities component.
	"""
  * component[obsDistribution].code = ObservationComponentSliceCodesCS#obsDistribution
 

  * component[obsDistribution].value[x] 1..1
  * component[obsDistribution].value[x] only CodeableConcept
  * component[obsDistribution].value[x] from CalcificationDistributionVS
 

  // Define distribution region size.

  * component contains obsDistRegionSize 0..1
  * component[obsDistRegionSize] ^short = "Observed size of distribution region. component."
  * component[obsDistRegionSize] ^comment = """
    This is one component of a group of components that are part of the observation.
    """
  * component[obsDistRegionSize] ^definition = """
This component slice contains the size of an region inside of which there 
is a distribution of abnormalities.

There may be one, two, or three values indicating a size of
one dimension (length), two dimensions (area), or three dimensions (volume).

Each dimension can be a quantity (i.e. 5), or a range (1 to 5).

If the lower bound of the range is set but not the upper bound, 
then the size is {lower bound} or greater.

If the upper bound of the range is set but not the lower bound, 

then the size is {upper bound} or less.
    """
  * component[obsDistRegionSize].code 1..1
  * component[obsDistRegionSize].code ^short = "Observed size of distribution region. component code."
  * component[obsDistRegionSize].code ^definition = """
    This code identifies the Observed size of distribution region. component.
	"""
  * component[obsDistRegionSize].code = ObservationComponentSliceCodesCS#obsDistRegionSize
	
  * component[obsDistRegionSize].value[x] 1..1
  * component[obsDistRegionSize].value[x] only Quantity or Range
  * component[obsDistRegionSize].valueQuantity units from UNITSOFLENGTH
  * component[obsDistRegionSize].valueRange.low units from UNITSOFLENGTH
  * component[obsDistRegionSize].valueRange.high units from UNITSOFLENGTH


  // Define distribution region size.

  * component contains obsSize 0..3
  * component[obsSize] ^short = "Observed size. component."
  * component[obsSize] ^comment = """
    This is one component of a group of components that are part of the observation.
    """
  * component[obsSize] ^definition = """
  This component slice contains the size of an item observed.
  There may be one, two, or three values indicating a size of
  one dimension (length), two dimensions (area), or three dimensions (volume).

  Each dimension can be a quantity (i.e. 5), or a range (1 to 5).

  If the lower bound of the range is set but not the upper bound, 
  then the size is {lower bound} or greater.
 
  If the upper bound of the range is set but not the lower bound,
  then the size is {upper bound} or less.
    """
  * component[obsSize].code 1..1
  * component[obsSize].code ^short = "Observed size. component code."
  * component[obsSize].code ^definition = """
    This code identifies the Observed size. component.
	"""
  * component[obsSize].code = ObservationComponentSliceCodesCS#obsSize
	
  * component[obsSize].value[x] 1..1
  * component[obsSize].value[x] only Quantity or Range
  * component[obsSize].valueQuantity units from UNITSOFLENGTH
  * component[obsSize].valueRange.low units from UNITSOFLENGTH
  * component[obsSize].valueRange.high units from UNITSOFLENGTH


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


  * component[prevDemBy].value[x] 1..1
  * component[prevDemBy].value[x] only CodeableConcept
  * component[prevDemBy].value[x] from PreviouslyDemonstratedByVS



  * hasMember ^slicing.discriminator.type = #value
  * hasMember ^slicing.discriminator.path = "url"
  * hasMember ^slicing.rules = #open
  * hasMember ^slicing.ordered = false
  * hasMember ^slicing.description = "Component slicing"
  * hasMember contains associatedFeature 0..*
  * hasMember[associatedFeature] ^short = "'Associated Feature' reference. hasMember."
  * hasMember[associatedFeature] only Reference(AssociatedFeature)