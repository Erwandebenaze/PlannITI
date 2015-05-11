var app = angular.module('plannITI')

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