app.controller("HomeController", ["$scope", "$http", function ($scope, $http) {
    //$scope.values = [];
    $scope.ItemName = [];
    $scope.DateOfPurchase = [];
    $scope.newItem = {};
   

    $http.get("api/item")
        .then(function (result) {
            $scope.values = result.data;

            console.log(result);
        });

    $scope.submitToPantryList = function () {

        $http.post('api/item', $scope.newItem)
            .then(function (res) {
                //$location.path('/pantry');
                $scope.newItem = {};
            });
        console.log($scope.newItem);
         }
    }
]);