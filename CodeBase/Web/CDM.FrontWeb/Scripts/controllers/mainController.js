'use strict';
app.controller('mainController', ['$scope', '$location', 'authService', 'dataService', function ($scope, $location, authService, dataService) {

    $scope.CurrentUser = dataService.userName;
    $scope.CurrentUser1 = "jdjdj";
    $scope.errorMessage = "";
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
    };

}]);