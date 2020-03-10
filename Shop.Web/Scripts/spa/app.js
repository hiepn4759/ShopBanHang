/// <reference path="../../assets/admin/libs/angular/angular.js" />

// tạo module trong angular
var myApp = angular.module('myModule', []);

//tạo controller trong angular
myApp.controller("myController", function ($scope) {
    $scope.message = "This is controller";
});