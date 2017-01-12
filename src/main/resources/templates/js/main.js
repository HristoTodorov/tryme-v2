var mainApp = angular.module("mainApp", []);

mainApp.constant('config', (function() {
    var apiVersion = 'v1.0';

    return {
        'apiVersion': apiVersion,
        'baseApiURL': '/api/'
    }
})());

mainApp.controller('MainCtrl', ['$scope', '$compile', function($scope, $compile) {
    $scope.recompile = function (htmlContent) {
        $compile(htmlContent)($scope);
    }
}]);
