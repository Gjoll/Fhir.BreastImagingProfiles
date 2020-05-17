
#include "Common.inc"
#use "HeaderFragment.inc"
#use "NodeGraph.inc"
#use "IntroDoc.inc"
#use "IGBuilder.inc"
// ObservedSize Fragment
// <b>Fragment that adds 'Observed Size' components to Observation.</b>

#macro ObservedSizeFragment()
#end
    //   "differential": {
    //     "element": [
    //       {
    //         "id": "Observation",
    //         "path": "Observation",
    //         "short": "Fragment that adds 'Observed Size' components to Observation.",
    //         "base": {
    //           "path": "Observation",
    //           "min": 0,
    //           "max": "*"
    //         }
    //       },
    //       {
    //         "id": "Observation.component",
    //         "path": "Observation.component",
    //         "slicing": {
    //           "discriminator": [
    //             {
    //               "type": "pattern",
    //               "path": "code"
    //             }
    //           ],
    //           "rules": "open"
    //         },
    //         "base": {
    //           "path": "Observation.component",
    //           "min": 0,
    //           "max": "*"
    //         }
    //       },
    //       {
    //         "id": "Observation.component:obsSize",
    //         "path": "Observation.component",
    //         "sliceName": "obsSize",
    //         "short": "Observed Size component.",
    //         "definition": "This component slice contains the size of an item observed.\n There may be one, two, or three values indicating a size of\n one dimension (length), two dimensions (area), or three dimensions (volume).\n Each dimension can be a quantity (i.e. 5), or a range (1 to 5).\n If the lower bound of the range is set but not the upper bound, then the size is {lower bound} or greater.\n If the upper bound of the range is set but not the lower bound, then the size is {upper bound} or less.",
    //         "comment": "This is one component of a group of components that are part of the observation.",
    //         "min": 0,
    //         "max": "3",
    //         "base": {
    //           "path": "Observation.component",
    //           "min": 0,
    //           "max": "*"
    //         }
    //       },
    //       {
    //         "id": "Observation.component:obsSize.code",
    //         "extension": [
    //           {
    //             "url": "http://www.fragment.com/DefaultValue",
    //             "valueCodeableConcept": {
    //               "coding": [
    //                 {
    //                   "system": "http://hl7.org/fhir/us/breast-radiology/CodeSystem/ObservationComponentSliceCodes",
    //                   "code": "obsSize",
    //                   "display": "Component code for 'Observed Size' slice"
    //                 }
    //               ],
    //               "text": "Component code for 'Observed Size' slice"
    //             }
    //           }
    //         ],
    //         "path": "Observation.component.code",
    //         "min": 1,
    //         "max": "1",
    //         "base": {
    //           "path": "Observation.component.code",
    //           "min": 1,
    //           "max": "1"
    //         },
    //         "patternCodeableConcept": {
    //           "coding": [
    //             {
    //               "system": "http://hl7.org/fhir/us/breast-radiology/CodeSystem/ObservationComponentSliceCodes",
    //               "code": "obsSize"
    //             }
    //           ]
    //         }
    //       },
    //       {
    //         "id": "Observation.component:obsSize.value[x]",
    //         "path": "Observation.component.value[x]",
    //         "slicing": {
    //           "discriminator": [
    //             {
    //               "type": "type",
    //               "path": "$this"
    //             }
    //           ],
    //           "rules": "closed"
    //         },
    //         "min": 1,
    //         "max": "1",
    //         "base": {
    //           "path": "Observation.component.value[x]",
    //           "min": 0,
    //           "max": "1"
    //         },
    //         "type": [
    //           {
    //             "code": "Quantity"
    //           },
    //           {
    //             "code": "Range"
    //           }
    //         ]
    //       },
    //       {
    //         "id": "Observation.component:obsSize.value[x]:valueQuantity",
    //         "path": "Observation.component.value[x]",
    //         "sliceName": "valueQuantity",
    //         "min": 0,
    //         "max": "1",
    //         "base": {
    //           "path": "Observation.component.value[x]",
    //           "min": 0,
    //           "max": "1"
    //         },
    //         "type": [
    //           {
    //             "code": "Quantity"
    //           }
    //         ],
    //         "patternQuantity": {
    //           "system": "http://hl7.org/fhir/us/breast-radiology/ValueSet/UnitsOfLengthVS"
    //         }
    //       },
    //       {
    //         "id": "Observation.component:obsSize.value[x]:valueRange",
    //         "path": "Observation.component.value[x]",
    //         "sliceName": "valueRange",
    //         "min": 0,
    //         "max": "1",
    //         "base": {
    //           "path": "Observation.component.value[x]",
    //           "min": 0,
    //           "max": "1"
    //         },
    //         "type": [
    //           {
    //             "code": "Range"
    //           }
    //         ],
    //         "patternRange": {
    //           "low": {
    //             "system": "http://hl7.org/fhir/us/breast-radiology/ValueSet/UnitsOfLengthVS"
    //           },
    //           "high": {
    //             "system": "http://hl7.org/fhir/us/breast-radiology/ValueSet/UnitsOfLengthVS"
    //           }
    //         }
    //       }
    //     ]
    //   }
    // }