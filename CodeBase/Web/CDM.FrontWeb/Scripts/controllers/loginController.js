'use strict';
app.controller('loginController', ['$scope', '$location', 'authService', 'dataService', function ($scope, $location, authService, dataService) {

    $scope.loginData = {
        userName: "",
        password: ""
    };

    $scope.errorMessage = "";
    $scope.initialRate = function () {
        if (authService.authentication.isAuth == true) {

            $location.path('/Home/Main');
        }
    };
    $scope.login = function () {

        authService.login($scope.loginData).then(function (response) {
            dataService.userName();
            $location.path('/Home/Main');

        },
         function (err) {
             $scope.errorMessage = err.error_description;
         });
    };

}]);