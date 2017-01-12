mainApp.controller('mainModuleCtrl', ['$scope', '$q', '$http', 'config', function($scope, $q, $http, config) {
    var userUrl = config.baseApiURL.concat("user");
    
    /**
     * Let is be pessimistic.
     */
    $scope.isLoggedIn = false;

    $scope.user = {};

    $scope.getUserRequest = function() {
        var deferred = $q.defer();

        $http({
            method : "GET",
            url : userUrl,
            cache: false
        }).then(function successCallback(data) {
            deferred.resolve(data);
        }, function errorCallback(data) {
            deferred.reject(data);
        });

        return deferred.promise;
    };
  
    $scope.mainModuleInit = function () {
        $scope.getUserRequest().then(function(data) {
            $scope.isLoggedIn = true;
            $scope.user.name = data.data.name;
            sessionStorage.setItem("userName", $scope.user.name);
        }, function(error) {
            // TODO: in case of an errror
        });
    };
}]);