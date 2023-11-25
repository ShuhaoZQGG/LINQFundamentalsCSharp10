using LINQSamples;

// Create instance of view model
SamplesViewModel vm = new();

// Call Sample Method
//var result = vm.InnerJoinQuery();
//var result = vm.InnerJoinMethod();
//var result = vm.InnerJoinTwoFieldsQuery();
//var result = vm.InnerJoinTwoFieldsMethod();
//var result = vm.JoinIntoQuery();
//var result = vm.JoinIntoMethod();
//var result = vm.LeftOuterJoinQuery();
var result = vm.LeftOuterJoinMethod();
// Display Results
vm.Display(result);