app.controller("HomeController", ["$scope", "$http", function ($scope, $http) {
    $scope.values = [];
    $scope.ItemName = [];
    $scope.DateOfPurchase = [];
    $scope.newItem = {};
   

    $http.get("api/staplesDb/get")
        .then(function (result) {
            $scope.values = result.data;
        });

    $scope.submitToPantryList = function () {

        $http.post('api/staplesDb', newItem)
            .then(function (res) {
                $location.path('/pantry');
                $scope.newItem = {};
            })
         }
    }
]);