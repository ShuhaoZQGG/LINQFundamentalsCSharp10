using LINQSamples;

// Create instance of view model
SamplesViewModel vm = new();

// Call Sample Method
var getAllQueryResult = vm.GetAllQuery();

var getAllMethodResult = vm.GetAllMethod();

var getSingleColumnQueryResult = vm.GetSingleColumnQuery();

var getSingleColumnMethodResult = vm.GetSingleColumnMethod();

var getSpecificColumnsQueryResult = vm.GetSpecificColumnsQuery();

var getSpecificColumnsMethodResult = vm.GetSpecificColumnsMethod();

var anonymousClassQueryResult = vm.AnonymousClassQuery();

var anonymousClassMethodResult = vm.AnonymousClassMethod();
vm.Display(anonymousClassMethodResult);