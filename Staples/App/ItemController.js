app.controller("ItemController", function ($q, $scope, $http) {

    $scope.ItemsModels = []
   


    let getItems = function () {

        return $q((resolve, reject) => {
            $http.get("api/item")
            .then(function (response) {
                resolve(response);

                for (var i = 0; i < response.data.length; i++) {
                    var item = response.data[i];
                    item.DateOfPurchase = moment(item.DateOfPurchase).format('dddd, MMM Do')
                    item.ExpirationDate = moment(item.ExpirationDate).fromNow()
                }

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

