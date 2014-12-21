'use strict';
app.controller('flight_Detail', ['$scope', '$location', 'authService', 'dataService', function ($scope, $location, authService, dataService) {

    //$scope.CurrentUser1 = "jdjdj";
    $scope.errorMessage = "";
    $scope.logout = function () {
        authService.logOut();
        $location.path('/Login');

    }
    $scope.initialRate = function () {
        if (!authService.authentication) {
            $scope.errorMessage = "You need to login to access the Page.";
            toastr.warning($scope.errorMessage);
            $location.path('/');
        }
        if (authService.authentication.isAuth != true) {
            $scope.errorMessage = "You need to login to access the Page.";
            toastr.warning($scope.errorMessage);
            $location.path('/');
        }
        dataService.userName().then(function success(data) {
            $scope.CurrentUser = data.UserName;
        });
    };

}]);