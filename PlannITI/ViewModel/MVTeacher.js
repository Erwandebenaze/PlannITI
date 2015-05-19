var teachersController = angular.module('teachersController', ['ngMessages']);

//ViewModel used
teachersController.controller( 'FormVMTeachers', ['$scope', function ( $scope ) {

    $scope.teacherSetting = teacherSetting;

    //Add a teacher
    $scope.addTeacher = function (name, mail) {
        if ($scope.teachersForm.$valid) {
            var newTeacher = { teacherName: name, teacherMail: mail };
            $scope.teacherSetting.teachers.push( newTeacher );
            $scope.teacherSetting.currentTeacher = newTeacher;
        }
      
    };
}] );

//ViewModel for the list
teachersController.controller( 'ListVMTeachers', ['$scope', function ( $scope ) {

    $scope.teacherSetting = teacherSetting;

    //Edit teacher
    $scope.editTeacher = function ( teacher ) {
        $scope.teacherSetting.currentTeacher = teacher;
    };

    // Delete a teacher
    $scope.deleteTeacher = function (teacher) {
        $scope.teacherSetting.teachers.splice($scope.teacherSetting.teachers.indexOf(teacher), 1);
    }
}] );