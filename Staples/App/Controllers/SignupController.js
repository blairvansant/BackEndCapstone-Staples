app.controller("SignupController", ["$scope", "$location","$http", function ($scope, $location,$http) {


    $scope.signup = function () {
        var newUser = {
            Email: $scope.Email,
            Password: $scope.Password,
            ConfirmPassword: $scope.ConfirmPassword
        }
        
        $http.post("/api/account/register", newUser);

        $location.path("/");
    }
}])