var app = angular.module("Staples", ["ngRoute"]);

app.config([
    "$routeProvider", function ($routeProvider) {
        $routeProvider
            .when("/",
            {
                templateUrl: "App/Partials/login.html",
                controller: "LoginController"
            })
            .when("/signup", {
                templateUrl: "App/Partials/signup.html",
                controller: "SignupController"
            })
            .when("/home",
            {
                templateUrl: "App/Partials/home.html",
                controller: "HomeController"
            });

    }
])

app.run(["$http", function ($http) {

    var token = sessionStorage.getItem('token');

    if (token)
        $http.defaults.headers.common['Authorization'] = `bearer ${token}`;

}
]);

