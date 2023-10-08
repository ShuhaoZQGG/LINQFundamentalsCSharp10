using LINQSamples;

// Create instance of view model
SamplesViewModel vm = new();

// Call Sample Method


// see a list of products ordered by price from low to high
//var result = vm.OrderByQuery();
// var result = vm.OrderByMethod();


// see a list of products ordered by price from high to low ((descending)
//var result = vm.OrderByDescendingQuery();
//var result = vm.OrderByDescendingMethod();

var result = vm.OrderByTwoFieldsQuery();
//var result = vm.OrderByTwoFieldsMethod();
//var result = vm.OrderByTwoFieldsDescMethod();

// Display Results
vm.Display(result);