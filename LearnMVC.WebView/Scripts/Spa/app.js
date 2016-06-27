/// <reference path="../Plugins/angular/angular.js" />

var myApp = angular.module('myModule', []);

myApp.controller("myController", myController);

myApp.directive("learnDirective", learnDirective);

myApp.service('validatorService', validatorService);

myController.$inject = ["$scope", 'validatorService'];


//declare
debugger;
function myController($scope, validatorService) {

    $scope.message = function () {
        $scope.message = validatorService.checkNumber($scope.number);
    }
}

function validatorService($window) {
    return {
        checkNumber: checkNumber
    }
    function checkNumber(input) {
        if (input % 2 == 0)
            return 'This is even';
        else
            return 'This is odd';
    }
}

function learnDirective() {
    return {
        restrict:"A",
        template: "<h1>This is the first custom directive</h1>"
    }
}