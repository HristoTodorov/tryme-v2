mainApp.controller('loginModuleCtrl', ['$scope', '$q', '$http', 'config', function($scope, $q, $http, config) {
    $scope.isLoggedIn = false;
    var userUrl = config.baseApiURL.concat("/user");
    $scope.getUserRequest = function() {
        var deferred = $q.defer();

        $http({
            method : "GET",
            url : userUrl,
            cache: false
        }).success(function(data) {
            deferred.resolve(data);
        }).error(function(data) {
            deferred.reject(data);
        });

        return deferred.promise;
    };

    $scope.loginModuleInit = function () {
        $scope.getUserRequest().then(function(data) {
            $scope.isLoggedIn = true;
        }, function(error) {
            // 
        });
    };
}]);