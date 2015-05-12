var plann = angular.module( 'plann', ['ngRoute', 'teachersController', 'roomsController'] );
plann.config( ['$routeProvider', function ( $routeProvider ) {

    $routeProvider.
        when( '/teachers', {
            templateUrl: '/View/VTeacher.html',
            controller: 'FormVMTeachers'
        } ).
                when( '/rooms', {
                    templateUrl: '/View/VRoom.html',
                    controller: 'FormVMRooms'
                } ).
      otherwise( { redirectTo: '/teachers' } );

}] );