var roomsController = angular.module( 'roomsController', [] );

    //ViewModel utilisé par le formulaire
roomsController.controller( 'FormVMRooms', ['$scope', function ( $scope ) {

    //charge le modèle dans le ViewModel
    $scope.roomSetting = roomSetting;

    //méthode d’ajout d’une room
    $scope.addRoom = function ( name, capacity ) {
        var newRoom = { roomName: name, roomCapacity: capacity };
        $scope.roomSetting.rooms.push( newRoom );
        $scope.roomSetting.currentRoom = newRoom;
    };
}] );

    //ViewModel utilisé par la liste
roomsController.controller( 'ListVMRooms', ['$scope', function ( $scope ) {

        //charge le même modèle
        $scope.roomSetting = roomSetting;

        //méthode permettant d’éditer une tâche
        $scope.editRoom = function ( room ) {
            $scope.roomSetting.currentRoom = room;
        };
    }] );
