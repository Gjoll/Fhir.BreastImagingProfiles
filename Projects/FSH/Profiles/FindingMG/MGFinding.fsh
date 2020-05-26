Profile: MGFinding
Parent: Observation
Title: "Mammography Finding"
Description: """
    Mammography Finding
    """

  //#apply Graph.LinkByName("focus", "^MGFinding/$", "^MGFinding/", "0")


 
  * code 1..1
  * code = ObservationCodesCS#mgFindingObservation

  * interpretation 0..0
  * referenceRange 0..0
  * basedOn 0..0
  * partOf 0..0
  * focus 0..0
  * specimen 0..0
  * contained 0..0
  * component 0..0
  * dataAbsentReason 0..0
  * value[x] 0..0
  * interpretation 0..0
  * referenceRange 0..0

  * interpretation 0..0
  * method 0..0  

    //       {
    //         "id": "Observation.hasMember:abnormalityCyst",
    //         "path": "Observation.hasMember",
    //         "sliceName": "abnormalityCyst",
    //         "short": "'Cyst' reference.",
    //         "definition": "This slice references the target 'Cyst'.",
    //         "min": 0,
    //         "max": "*",
    //         "base": {
    //           "path": "Observation.hasMember",
    //           "min": 0,
    //           "max": "*"
    //         },
    //         "type": [
    //           {
    //             "code": "Reference",
    //             "targetProfile": [
    //               "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/AbnormalityCyst"
    //             ]
    //           }
    //         ]
    //       },
    //       {
    //         "id": "Observation.hasMember:abnormalityDuct",
    //         "path": "Observation.hasMember",
    //         "sliceName": "abnormalityDuct",
    //         "short": "'Duct' reference.",
    //         "definition": "This slice references the target 'Duct'.",
    //         "min": 0,
    //         "max": "*",
    //         "base": {
    //           "path": "Observation.hasMember",
    //           "min": 0,
    //           "max": "*"
    //         },
    //         "type": [
    //           {
    //             "code": "Reference",
    //             "targetProfile": [
    //               "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/AbnormalityDuct"
    //             ]
    //           }
    //         ]
    //       },
    //       {
    //         "id": "Observation.hasMember:abnormalityForeignObject",
    //         "path": "Observation.hasMember",
    //         "sliceName": "abnormalityForeignObject",
    //         "short": "'Foreign Object' reference.",
    //         "definition": "This slice references the target 'Foreign Object'.",
    //         "min": 0,
    //         "max": "*",
    //         "base": {
    //           "path": "Observation.hasMember",
    //           "min": 0,
    //           "max": "*"
    //         },
    //         "type": [
    //           {
    //             "code": "Reference",
    //             "targetProfile": [
    //               "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/AbnormalityForeignObject"
    //             ]
    //           }
    //         ]
    //       },
    //       {
    //         "id": "Observation.hasMember:abnormalityLymphNode",
    //         "path": "Observation.hasMember",
    //         "sliceName": "abnormalityLymphNode",
    //         "short": "'LymphNode' reference.",
    //         "definition": "This slice references the target 'LymphNode'.",
    //         "min": 0,
    //         "max": "*",
    //         "base": {
    //           "path": "Observation.hasMember",
    //           "min": 0,
    //           "max": "*"
    //         },
    //         "type": [
    //           {
    //             "code": "Reference",
    //             "targetProfile": [
    //               "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/AbnormalityLymphNode"
    //             ]
    //           }
    //         ]
    //       },
    //       {
    //         "id": "Observation.hasMember:abnormalityMass",
    //         "path": "Observation.hasMember",
    //         "sliceName": "abnormalityMass",
    //         "short": "'Mass' reference.",
    //         "definition": "This slice references the target 'Mass'.",
    //         "min": 0,
    //         "max": "*",
    //         "base": {
    //           "path": "Observation.hasMember",
    //           "min": 0,
    //           "max": "*"
    //         },
    //         "type": [
    //           {
    //             "code": "Reference",
    //             "targetProfile": [
    //               "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/AbnormalityMass"
    //             ]
    //           }
    //         ]
    //       },
    //       {
    //         "id": "Observation.hasMember:associatedFeature",
    //         "path": "Observation.hasMember",
    //         "sliceName": "associatedFeature",
    //         "short": "'Associated Feature' reference.",
    //         "definition": "This slice references the target 'Associated Feature'.",
    //         "min": 0,
    //         "max": "*",
    //         "base": {
    //           "path": "Observation.hasMember",
    //           "min": 0,
    //           "max": "*"
    //         },
    //         "type": [
    //           {
    //             "code": "Reference",
    //             "targetProfile": [
    //               "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/AssociatedFeature"
    //             ]
    //           }
    //         ]
    //       },
    //       {
    //         "id": "Observation.hasMember:abnormalityFibroadenoma",
    //         "path": "Observation.hasMember",
    //         "sliceName": "abnormalityFibroadenoma",
    //         "short": "'Fibroadenoma' reference.",
    //         "definition": "This slice references the target 'Fibroadenoma'.",
    //         "min": 0,
    //         "max": "*",
    //         "base": {
    //           "path": "Observation.hasMember",
    //           "min": 0,
    //           "max": "*"
    //         },
    //         "type": [
    //           {
    //             "code": "Reference",
    //             "targetProfile": [
    //               "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/AbnormalityFibroadenoma"
    //             ]
    //           }
    //         ]
    //       },
    //       {
    //         "id": "Observation.hasMember:mGAbnormalityArchitecturalDistortion",
    //         "path": "Observation.hasMember",
    //         "sliceName": "mGAbnormalityArchitecturalDistortion",
    //         "short": "'Mammography Architectural Distortion' reference.",
    //         "definition": "This slice references the target 'Mammography Architectural Distortion'.",
    //         "min": 0,
    //         "max": "*",
    //         "base": {
    //           "path": "Observation.hasMember",
    //           "min": 0,
    //           "max": "*"
    //         },
    //         "type": [
    //           {
    //             "code": "Reference",
    //             "targetProfile": [
    //               "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/MGAbnormalityArchitecturalDistortion"
    //             ]
    //           }
    //         ]
    //       },
    //       {
    //         "id": "Observation.hasMember:mGAbnormalityAsymmetry",
    //         "path": "Observation.hasMember",
    //         "sliceName": "mGAbnormalityAsymmetry",
    //         "short": "'Mammography Asymmetry' reference.",
    //         "definition": "This slice references the target 'Mammography Asymmetry'.",
    //         "min": 0,
    //         "max": "*",
    //         "base": {
    //           "path": "Observation.hasMember",
    //           "min": 0,
    //           "max": "*"
    //         },
    //         "type": [
    //           {
    //             "code": "Reference",
    //             "targetProfile": [
    //               "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/MGAbnormalityAsymmetry"
    //             ]
    //           }
    //         ]
    //       },
    //       {
    //         "id": "Observation.hasMember:mGAbnormalityCalcification",
    //         "path": "Observation.hasMember",
    //         "sliceName": "mGAbnormalityCalcification",
    //         "short": "'Mammography Calcification' reference.",
    //         "definition": "This slice references the target 'Mammography Calcification'.",
    //         "min": 0,
    //         "max": "*",
    //         "base": {
    //           "path": "Observation.hasMember",
    //           "min": 0,
    //           "max": "*"
    //         },
    //         "type": [
    //           {
    //             "code": "Reference",
    //             "targetProfile": [
    //               "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/MGAbnormalityCalcification"
    //             ]
    //           }
    //         ]
    //       },
    //       {
    //         "id": "Observation.hasMember:mGAbnormalityDensity",
    //         "path": "Observation.hasMember",
    //         "sliceName": "mGAbnormalityDensity",
    //         "short": "'Mammography Density' reference.",
    //         "definition": "This slice references the target 'Mammography Density'.",
    //         "min": 0,
    //         "max": "*",
    //         "base": {
    //           "path": "Observation.hasMember",
    //           "min": 0,
    //           "max": "*"
    //         },
    //         "type": [
    //           {
    //             "code": "Reference",
    //             "targetProfile": [
    //               "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/MGAbnormalityDensity"
    //             ]
    //           }
    //         ]
    //       },
    //       {
    //         "id": "Observation.hasMember:mGAbnormalityFatNecrosis",
    //         "path": "Observation.hasMember",
    //         "sliceName": "mGAbnormalityFatNecrosis",
    //         "short": "'Mammography Fat Necrosis' reference.",
    //         "definition": "This slice references the target 'Mammography Fat Necrosis'.",
    //         "min": 0,
    //         "max": "*",
    //         "base": {
    //           "path": "Observation.hasMember",
    //           "min": 0,
    //           "max": "*"
    //         },
    //         "type": [
    //           {
    //             "code": "Reference",
    //             "targetProfile": [
    //               "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/MGAbnormalityFatNecrosis"
    //             ]
    //           }
    //         ]
    //       },
    //       {
    //         "id": "Observation.hasMember:mGBreastDensity",
    //         "path": "Observation.hasMember",
    //         "sliceName": "mGBreastDensity",
    //         "short": "'Mammography Breast Density' reference.",
    //         "definition": "This slice references the target 'Mammography Breast Density'.",
    //         "min": 1,
    //         "max": "1",
    //         "base": {
    //           "path": "Observation.hasMember",
    //           "min": 0,
    //           "max": "*"
    //         },
    //         "type": [
    //           {
    //             "code": "Reference",
    //             "targetProfile": [
    //               "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/MGBreastDensity"
    //             ]
    //           }
    //         ]
    //       }
    //     ]
    //   }
    // }