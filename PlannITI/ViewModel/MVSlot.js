﻿var slotsController = angular.module('slotsController', ['ngMessages']);

//ViewModel for the Form
slotsController.controller('FormVMSlots', ['$scope', function ($scope) {

    $scope.slotSetting = slotSetting;
    $scope.savedRooms = roomSetting.rooms;
    $scope.savedSubjects = subjectSetting.subjects;

    //Add a slot
    $scope.addSlot = function (room, material, date, moment) {
        if ($scope.slotsForm.$valid) {
            var newSlot = { slotRoom: room, slotMaterial: material, slotDate: date, slotMoment: moment };
            $scope.slotSetting.slots.push(newSlot);
            $scope.slotSetting.currentSlot = newSlot;
        }
    };

    //Filters for the dropdown list
    $scope.isSubjectDefined = function (subject) {
        return typeof subject.subjectName !== "undefined";
    }
    $scope.isRoomDefined = function (room) {
        return typeof room.roomName !== "undefined";
    }
}]);

//ViewModel for the list
slotsController.controller('ListVMSlots', ['$scope', function ($scope) {

    $scope.slotSetting = slotSetting;

    //Edit slot
    $scope.editSlot = function (slot) {
        $scope.slotSetting.currentSlot = slot;
    };

    // Delete a slot
    $scope.deleteSlot = function (slot) {
        $scope.slotSetting.slots.splice($scope.slotSetting.slots.indexOf(slot), 1);
    }
}]);