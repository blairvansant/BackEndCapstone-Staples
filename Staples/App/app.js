var app = angular.module("Staples", ["ngRoute"]);

app.config([
    "$routeProvider", "$locationProvider", function ($routeProvider, $locationProvider) {
        $routeProvider
            .when("/", {
                templateUrl: "App/Partials/login.html",
                controller: "LoginController"
            })
            .when("/signup", {
                templateUrl: "App/Partials/signup.html",
                controller: "SignupController"
            })
            .when("/pantry", {
                templateUrl: "App/Partials/item.html",
                controller: "ItemController"
            })
             .when("/home", {
                 templateUrl: "App/Partials/home.html",
                 controller: "HomeController"
             })
            .otherwise({ redirectTo: "/" });
         
    }
])

app.run(["$http", function ($http) {

    var token = sessionStorage.getItem('token');

    if (token)
        $http.defaults.headers.common['Authorization'] = `bearer ${token}`;

}
]);

