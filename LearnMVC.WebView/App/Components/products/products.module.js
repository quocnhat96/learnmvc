/// <reference path="C:\Users\thaiq\Documents\Visual Studio 2015\Projects\SourceCode\Git\LearnMVC.WebView\Assets/Admin/libs/angular/angular.js" />
(function () {
    angular.module("learnMVC.products", ['learnMVC.common']).config(config);

    config.$inject = ['$stateProvider', '$urlRouterProvider'];

    function config($stateProvider, $urlRouterProvider) {
        $stateProvider.state('products', {
            url: "/products",
            templateUrl: "/App/Components/products/productListView.html",
            controller: "productListController"
        }).state('products_add', {
            url: "/products_add",
            templateUrl: "/App/Components/products/productAddView.html",
            controller: "productAddController"
    })
    }
})();