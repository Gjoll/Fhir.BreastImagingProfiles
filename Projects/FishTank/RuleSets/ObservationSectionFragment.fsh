// ObservationSectionFragment
// Constrains a generic observation to be a observation section.

// IncompatibleFragment ObservationLeafFragment

RuleSet: ObservationSectionFragment
//+Mixins: ObservationFragment, ObservationNoComponentFragment, ObservationNoValueFragment
//-Mixins:
  * interpretation 0..0
  * method 0..0
