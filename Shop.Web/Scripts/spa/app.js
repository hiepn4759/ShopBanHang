/// <reference path="../../assets/admin/libs/angular/angular.js" />

// tạo module trong angular
var myApp = angular.module('myModule', []);

//tạo controller trong angular
myApp.controller("schoolController", schoolController);
myApp.controller("studentController", studentController);
myApp.controller("teacherController", teacherController);

function schoolController($scope) {
    $scope.message = "This is school";
}
function studentController($scope) {
    $scope.message = "This is student";
}
function teacherController($scope) {
    $scope.message = "This is teacher";
}