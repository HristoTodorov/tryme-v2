mainApp.controller('beginTestModuleCtrl', ['$scope', '$q', '$http', 'config', function($scope, $q, $http, config) {
    var requestTestUrl = config.baseApiURL.concat("tests/{testId}");
    $scope.description = "";
    $scope.userName = "";
    $scope.getTestRequest = function() {
        var deferred = $q.defer();

        $http({
            method : "GET",
            url : requestTestUrl,
            cache: false
        }).then(function successCallback(data) {
            deferred.resolve(data);
        }, function errorCallback(data) {
            deferred.reject(data);
        });

        return deferred.promise;
    };

    $scope.questions = [];

    $scope.beginTestModuleInit = function () {
        $scope.userName = sessionStorage.getItem("userName");
        $scope.getTestRequest(sessionStorage.getItem("testId")).then(function(data) {
            $scope.description = data.data.description;
            data = data.data.questions;
        	for(var i=0;i<data.length;i++){
        	    $scope.questions.push(
        		{
        			id: data[i].id,
        			subject: data[i].text,
        			answers: data[i].answers
        		});
            }
        }, function(error) {
            // TODO: in case of an errror
        });
    };
}]);