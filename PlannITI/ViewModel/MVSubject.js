﻿var subjectsController = angular.module('subjectsController', ['ngMessages']);

//ViewModel for the Form
subjectsController.controller('FormVMSubjects', ['$scope', function ($scope) {

    $scope.subjectSetting = subjectSetting;
    $scope.savedTeachers = teacherSetting.teachers;
    $scope.savedTeachers_selection = $scope.savedTeachers[1];
    
    //Add a subject
    $scope.addSubject = function (name, defaultTeacher, slotsByPeriod) {
        if ($scope.subjectForm.$valid) {
            var newSubject = { subjectName: name, subjectDefaultTeacher: defaultTeacher, subjectSlotsByPeriod: slotsByPeriod };
            $scope.subjectSetting.subjects.push(newSubject);
            $scope.subjectSetting.currentSubject = newSubject;
        }
    };
}]);

//ViewModel for the list
subjectsController.controller('ListVMSubjects', ['$scope', function ($scope) {

    $scope.subjectSetting = subjectSetting;

    //Edit a subject
    $scope.editSubject = function (subject) {
        $scope.subjectSetting.currentSubject = subject;
    };

    // Delete a subject
    $scope.deleteSubject = function (subject) {
        $scope.subjectSetting.subjects.splice($scope.subjectSetting.subjects.indexOf(subject), 1);
    }
}]);