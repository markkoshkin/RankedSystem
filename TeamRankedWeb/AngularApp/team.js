app.service("team", ["$http", "$q", function ($http, $q) {
    var baseUrl = "api/selection/";
    this.completeTeams = function (teams) {
        return $http.post(baseUrl, JSON.stringify(teams)).then(function (responce) {
            return responce.data;
        });
    }
}]);