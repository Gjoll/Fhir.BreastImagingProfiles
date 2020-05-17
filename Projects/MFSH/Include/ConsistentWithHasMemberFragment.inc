
#include "Common.inc"
#use "HeaderFragment.inc"
#use "NodeGraph.inc"
#use "IntroDoc.inc"
#use "IGBuilder.inc"

// ConsistentWith HasMember Fragment
// This fragment adds the references for the ConsistentWith HasMember.
#macro ConsistentWithHasMemberFragment()
  #apply ObservationAddHasMember("consistentWith", "0..*", "Consistent With", "'Consistent With' reference.",
  """
  This slice references the target 'Consistent With'.
  """)
#end
    //       {
    //         "type": [
    //           {
    //             "code": "Reference",
    //             "targetProfile": [
    //               "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/ConsistentWith"
    //             ]
    //           }
    //         ]
    //       }
    //     ]
    //   }
    // }