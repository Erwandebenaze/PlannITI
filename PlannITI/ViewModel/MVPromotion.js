var promotionsController = angular.module('promotionsController', ['ngMessages']);

//ViewModel for the Form
promotionsController.controller('FormVMPromotions', ['$scope', function ($scope) {

    $scope.promotionSetting = promotionSetting;

    //Add a room
    $scope.addPromotion = function (name, number, mail) {
        if ($scope.promotionsForm.$valid) {
            var newPromotion = { promotionName: name, promotionNumber : number, promotionMail: mail };
            $scope.promotionSetting.promotions.push(newPromotion);
            $scope.promotionSetting.currentPromotion = newPromotion;
        }
        
    };
}]);

//ViewModel for the list
promotionsController.controller('ListVMPromotions', ['$scope', function ($scope) {

    $scope.promotionSetting = promotionSetting;

    //Edit promotion
    $scope.editPromotion = function (promotion) {
        $scope.promotionSetting.currentPromotion = promotion;
    };

    // Delete a promotion
    $scope.deletePromotion = function (promotion) {
        $scope.promotionSetting.promotions.splice($scope.promotionSetting.promotions.indexOf(promotion), 1);
    }
}]);