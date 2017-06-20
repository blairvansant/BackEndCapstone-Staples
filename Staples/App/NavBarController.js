"use strict";

app.controller('NavBarController', function ($scope) {
    $scope.navItems = [
      //{
      //    name: "Logout",
      //    url: "#!/logout"
      //},
      {
          name: "My Staples",
          url: "#!/pantry"
      },
      {
          name: "Add a Staple",
          url: "#!/home"
      }
    ];
});