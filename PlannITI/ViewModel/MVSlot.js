var slotsController = angular.module('slotsController', ['ngMessages']);

//ViewModel for the Form
slotsController.controller('FormVMSlots', ['$scope', function ($scope) {

    $scope.slotSetting = slotSetting;

    //Add a slot
    $scope.addSlot = function (room, material, date, moment) {
        if ($scope.slotsForm.$valid) {
            var newSlot = { slotRoom: room, slotMaterial: material, slotDate: date, slotMoment: moment };
            $scope.slotSetting.slots.push(newSlot);
            $scope.slotSetting.currentSlot = newSlot;
        }
    };
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