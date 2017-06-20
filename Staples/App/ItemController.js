app.controller("ItemController", function ($q, $scope, $http) {

    $scope.ItemsModels = []
   


    let getItems = function () {

        return $q((resolve, reject) => {
            $http.get("api/item")
            .then(function (response) {
                resolve(response);
                $scope.ItemsModels = response.data;

                console.log("respone from my api", response);
                console.log("scoped items", $scope.ItemsModels);

            }, function (errorResponse) {
                reject(errorResponse);
            });
        });
    }

    getItems();

         $scope.deleteFoodItems = function (id) {
            return $q((resolve, reject) => {
                $http.delete(`api/item/${id}`)
                .then(function (response) {
                    resolve(response);
                    getItems();
                    console.log($scope.deleteFoodItems, "delete")

                },

                    function (errorResponse) {
                        reject(errorResponse);
                    });
            });
    }

});

