mainApp.controller('categoriesModuleCtrl', ['$scope', '$q', '$http', '$location', 'config', function($scope, $q, $http, $location, config) {
    var categoriesUrl = config.baseApiURL.concat("tests/categories/");
    var subCategoryUrl = config.baseApiURL.concat("tests/categories/{category}/descriptions");
 
    $scope.getCategoriesRequest = function() {
        var deferred = $q.defer();

        $http({
            method : "GET",
            url : categoriesUrl,
            cache: false
        }).then(function successCallback(data) {
            deferred.resolve(data);
        }, function errorCallback(data) {
            deferred.reject(data);
        });

        return deferred.promise;
    };
  
      $scope.getSubCategory = function(category) {
        var deferred = $q.defer();

        $http({
            method : "GET",
            url : subCategoryUrl.replace("{category}", category),
            cache: false
        }).then(function successCallback(data) {
            deferred.resolve(data);
        }, function errorCallback(data) {
            deferred.reject(data);
        });

        return deferred.promise;
    };

    $scope.categories = [];
    
    $scope.subCategories = [];

    $scope.testCategory = "";
    
    $scope.testSubCategory = "";

    $scope.userName = "";
    
    $scope.isMainCategorySelected = false;

    $scope.categoriesModuleInit = function () {
        $scope.getCategoriesRequest().then(function(data) {
            data = data.data;
        	for(var i=0;i<data.length;i++){
        	    $scope.categories.push(
        		{
        			id: data[i].id,
        			name: data[i].name,
        			testCount: data[i].testCount
        		});
            }
        	$scope.userName = sessionStorage.getItem("userName");
        }, function(error) {
            // TODO: in case of an errror
        });
    };
    

    $scope.mainCategoryListener = function () {
    	$scope.getSubCategory($scope.testCategory).then(function(data) {
            data = data.data;
            var len = data.length;
            var i = 0;
            $scope.subCategories = [];
            for (; i < len; i++) {
                $scope.subCategories.push({
                    id: data[i].id,
                    subject: data[i].subject
                });
            }
            $scope.isMainCategorySelected = true;
        }, function(error) {
            // Do nothing
        })
    };

    $scope.beginTest = function () {
        sessionStorage.setItem("testId", $scope.testSubCategory);
        window.location.href = "/test";
    };

}]);