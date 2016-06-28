/// <reference path="C:\Users\thaiq\Documents\Visual Studio 2015\Projects\SourceCode\Git\LearnMVC.WebView\Assets/Admin/libs/angular/angular.js" />
(function () {
    angular.module("learnMVC", ['learnMVC.products','learnMVC.common']).config(config);
    
    config.$inject = ['$stateProvider', '$urlRouterProvider'];

    function config($stateProvider, $urlRouterProvider) {
        $stateProvider.state('Home', {
            url: "/Admin",
            templateUrl: "/App/Components/home/homeView.html",
            controller: "homeController"
        });
        $urlRouterProvider.otherwise('/Admin');
    }
})();