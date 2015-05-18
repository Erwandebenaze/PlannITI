var periodsController = angular.module('periodsController', []);

//ViewModel utilisé par le formulaire
periodsController.controller('FormVMPeriods', ['$scope', function ($scope) {

    //charge le modèle dans le ViewModel
    $scope.periodSetting = periodSetting;

    //méthode d’ajout d’une periode
    $scope.addPeriod = function (name, beginDate, endDate) {
        var newPeriod = { periodName: name, periodBeginDate: beginDate, periodEndDate : endDate };
        $scope.periodSetting.periods.push(newPeriod);
        $scope.periodSetting.currentPeriod = newPeriod;
    };
}]);

//ViewModel utilisé par la liste
periodsController.controller('ListVMPeriods', ['$scope', function ($scope) {

    //charge le même modèle
    $scope.periodSetting = periodSetting;

    //méthode permettant d’éditer une tâche
    $scope.editPeriod = function (period) {
        $scope.periodSetting.currentPeriod = period;
    };

    //$scope.addHolidayToPeriod = function (beginDate, endDate) {
    //    var newHoliday = { holidayBeginDate: beginDate, holidayEndDate: endDate };
    //    $scope.periodSetting.currentPeriod.holidays.push(newHoliday);
    //};

    //$scope.editHoliday = function (holiday) {
    //    $scope.periodSetting.currentPeriod.holidays;
    //};
}]);