var promotionsController = angular.module('promotionsController', []);

//ViewModel utilisé par le formulaire
promotionsController.controller('FormVMPromotions', ['$scope', function ($scope) {

    //charge le modèle dans le ViewModel
    $scope.promotionSetting = promotionSetting;

    //méthode d’ajout d’une room
    $scope.addPromotion = function (name, number, mail) {
        var newPromotion = { promotionName: name, promotionNumber : number, promotionMail: mail };
        $scope.promotionSetting.promotions.push(newPromotion);
        $scope.promotionSetting.currentPromotion = newPromotion;
    };
}]);

//ViewModel utilisé par la liste
promotionsController.controller('ListVMPromotions', ['$scope', function ($scope) {

    //charge le même modèle
    $scope.promotionSetting = promotionSetting;

    //méthode permettant d’éditer une tâche
    $scope.editPromotion = function (promotion) {
        $scope.promotionSetting.currentPromotion = promotion;
    };
}]);