var periodsController = angular.module('periodsController', ['ngMessages']);

//ViewModel for the Form
periodsController.controller('FormVMPeriods', ['$scope', function ($scope) {

    $scope.periodSetting = periodSetting;

    //Add a period
    $scope.addPeriod = function (name, beginDate, endDate) {
        if ($scope.periodsForm.$valid) {
            var newPeriod = { periodName: name, periodBeginDate: beginDate, periodEndDate : endDate };
            $scope.periodSetting.periods.push(newPeriod);
            $scope.periodSetting.currentPeriod = newPeriod;
        }
    };
}]);

//ViewModel for the list
periodsController.controller('ListVMPeriods', ['$scope', function ($scope) {

    $scope.periodSetting = periodSetting;

    //Edit period
    $scope.editPeriod = function (period) {
        $scope.periodSetting.currentPeriod = period;
    };

    // Delete a period
    $scope.deletePeriod = function (period) {
        $scope.periodSetting.periods.splice($scope.periodSetting.periods.indexOf(period), 1);
    }

    //$scope.addHolidayToPeriod = function (beginDate, endDate) {
    //    var newHoliday = { holidayBeginDate: beginDate, holidayEndDate: endDate };
    //    $scope.periodSetting.currentPeriod.holidays.push(newHoliday);
    //};

    //$scope.editHoliday = function (holiday) {
    //    $scope.periodSetting.currentPeriod.holidays;
    //};
}]);