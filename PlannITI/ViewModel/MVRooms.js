var app = angular.module('plannITI', [])

    //ViewModel utilisé par le formulaire
    .controller('FormVMRooms', ['$scope', function ($scope) {

        //charge le modèle dans le ViewModel
        $scope.roomSetting = roomSetting;

        //méthode d’ajout d’une room
        $scope.addRoom = function (name, capacity) {
            var newRoom = { roomName: name, roomCapacity: capacity };
            $scope.roomSetting.rooms.push(newRoom);
            $scope.roomSetting.currentRoom = newRoom;
        };
    }])

    //ViewModel utilisé par la liste
    .controller('ListVMRooms', ['$scope', function ($scope) {

        //charge le même modèle
        $scope.roomSetting = roomSetting;

        //méthode permettant d’éditer une tâche
        $scope.editRoom = function (room) {
            $scope.roomSetting.currentRoom = room;
        };
    }])
//ViewModel utilisé par le formulaire
    .controller('FormVMTeachers', ['$scope', function ($scope) {

        //charge le modèle dans le ViewModel
        $scope.teacherSetting = teacherSetting;

        //méthode d’ajout d’une room
        $scope.addTeacher = function (name, mail) {
            var newTeacher = { teacherName: name, teacherMail: mail };
            $scope.teacherSetting.teachers.push(newTeacher);
            $scope.teacherSetting.currentTeacher = newTeacher;
        };
    }])

    //ViewModel utilisé par la liste
    .controller('ListVMTeachers', ['$scope', function ($scope) {

        //charge le même modèle
        $scope.teacherSetting = teacherSetting;

        //méthode permettant d’éditer une tâche
        $scope.editTeacher = function (teacher) {
            $scope.teacherSetting.currentTeacher = teacher;
        };
    }]);