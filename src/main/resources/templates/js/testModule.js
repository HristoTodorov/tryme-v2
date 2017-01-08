mainApp.controller('testModuleCtrl', ['$scope', '$q', '$http', 'config', function($scope, $q, $http, config) {
    var categoriesUrl = config.baseApiURL.concat("/tests/categories/");
    
    $scope.getCategoriesRequest = function() {
        var deferred = $q.defer();

        $http({
            method : "GET",
            url : categoriesUrl,
            cache: false
        }).success(function(data) {
            deferred.resolve(data);
        }).error(function(data) {
            deferred.reject(data);
        });

        return deferred.promise;
    };
  
    $scope.categories = {};
    $scope.testModuleInit = function () {
        $scope.getCategoriesRequest().then(function(data) {
            for(var i=0;i<data.length;i++){
        	    $scope.categories.push(
        		{
        			id: data.id,
        			name: data.name,
        			testCount: data.testCount
        		});
            }
        }, function(error) {
            // TODO: in case of an errror
        });
    };
}]);