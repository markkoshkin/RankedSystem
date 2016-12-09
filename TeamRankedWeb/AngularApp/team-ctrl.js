app.controller("teamCtrl", ["$scope", "team", function ($scope, team) {
    $scope.teams;
    $scope.players = [];
    $scope.isValidPlayers;
    var index = 0;

    $scope.$watchCollection('players', function (newVal, oldVal) {
        if (newVal.length === 18) {
            $scope.isValidPlayers = true;
        } else {
            $scope.isValidPlayers = false;
        }
    });

    $scope.addPlayer = function () {
        if (isValidPlayer($scope.newPlayer)) {
            $scope.players.push({
                Index: index++,
                Name: $scope.newPlayer.Name,
                Rating: $scope.newPlayer.Rating
            });
        } else {
            alert("Not valid Player");
        }
    };

    $scope.completeTeams = function () {
        team.completeTeams($scope.players).then(function (teams) {
            $scope.teams = teams;
        });
    };

    $scope.removeAllPlayers = function () {
        $scope.players.length = 0;
    };

    $scope.removePlayer = function (player) {
        var index = $scope.players.indexOf(player);
        $scope.players.splice(index, 1);
    };

    var isValidPlayer = function (player) {
        if (player.Name && player.Rating >= 1 && player.Rating <= 10) {
            return true;
        } else {
            return false;
        }
    };
}]);