var app = angular.module('plannITI', ['ngRoute'])
.config(function ($routeProvider) {

    $routeProvider.when('/teachers', {
        templateUrl: '/View/VTeacher.html',
        controller: 'FormVMTeachers'
    });
    $routeProvider.otherwise({ redirectTo: '/teachers'});

});