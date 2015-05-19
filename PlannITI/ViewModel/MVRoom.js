var roomsController = angular.module('roomsController', ['ngMessages']);

//ViewModel for the Form
roomsController.controller( 'FormVMRooms', ['$scope', function ( $scope ) {

    $scope.roomSetting = roomSetting;

    //Add a room
    $scope.addRoom = function (name, capacity) {
        if ($scope.roomForm.$valid) {
            var newRoom = { roomName: name, roomCapacity: capacity };
            $scope.roomSetting.rooms.push(newRoom);
            $scope.roomSetting.currentRoom = newRoom;
        }
    };
}] );

//ViewModel for the list
roomsController.controller( 'ListVMRooms', ['$scope', function ( $scope ) {

        $scope.roomSetting = roomSetting;

        //Edit room
        $scope.editRoom = function ( room ) {
            $scope.roomSetting.currentRoom = room;
        };

        // Delete a room
        $scope.deleteRoom = function ( room ) {
            $scope.roomSetting.rooms.splice( $scope.roomSetting.rooms.indexOf(room),1 );
        }
    }]);
