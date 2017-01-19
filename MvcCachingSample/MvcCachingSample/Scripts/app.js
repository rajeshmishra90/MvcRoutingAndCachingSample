var myapp = angular.module("myApp", ['ngRoute']);

var configFunction = function ($routeProvider) {
    $routeProvider.
        when('/:process/dashboard', {
            templateUrl: function (params) { return '/' + params.process+'/Dashboard' }
        })
        .when('/MyJobs/:process', {
            //templateUrl: function (params) { return '/home/MyJobs?process=' + params.process; }
            templateUrl: function (params) { return '/' + params.process + '/MyJobs' }
        })
        .when('/Admin/:process', {
            //templateUrl: function (params) { return '/home/Admin?process=' + params.process; }
            templateUrl: function (params) { return '/' + params.process + '/Admin' }
        });
}
configFunction.$inject = ['$routeProvider'];

myapp.config(configFunction)

//Montoring=IDC/Dashboard
//Admin=IDC/Admin
//MyJobs=IDC/MyJobs

//JSON Data(GET)=Home/GetData