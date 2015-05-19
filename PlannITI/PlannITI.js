var plann = angular.module('plann', ['ngRoute', 'teachersController', 'roomsController', 'periodsController', 'promotionsController', 'subjectsController', 'slotsController']);
plann.config( ['$routeProvider', function ( $routeProvider ) {

    $routeProvider.
        when( '/teachers', {
            templateUrl: '/View/VTeacher.html',
            controller: 'FormVMTeachers'
        } ).
        when( '/rooms', {
            templateUrl: '/View/VRoom.html',
            controller: 'FormVMRooms'
        }).
        when('/periods', {
            templateUrl: '/View/VPeriods.html',
            controller: 'FormVMPeriods'
        }).
        when('/promotions', {
            templateUrl: '/View/VPromotion.html',
            controller: 'FormVMPromotions'
        }).
        when('/subjects', {
            templateUrl: '/View/VSubject.html',
            controller: 'FormVMSubjects'
        }).
        when('/slots', {
            templateUrl: '/View/VSlots.html',
            controller: 'FormVMSlots'
        }).
      otherwise( { redirectTo: '/' } );

}] );