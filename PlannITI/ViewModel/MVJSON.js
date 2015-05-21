var phonecatApp = angular.module( 'plann');

phonecatApp.controller( 'PhoneListCtrl', ['$scope', '$http', function ( $scope, $http ) {
    $http.get( '/JSON/test.json' ).success( function ( data ) {
        $scope.phones = data;
        console.log( "Succès de la récupération de test.json" );
        
    } ).error( function( data )
    {
        console.log( "Récupération du test.json échouée" );
})
    ;

    $scope.save = function ( textInJson ) {
        console.log( "textInJson : " + textInJson );
        
        console.log( "JSON.stringify : " + JSON.stringify( textInJson ) );
        console.log( JSON.parse( JSON.stringify( textInJson ) ) );

    };
}] );