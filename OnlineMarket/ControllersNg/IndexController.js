var app = angular.module('OnlineMarket', ['ngRoute']);

app.config(function ($routeProvider) {
    $routeProvider

        .when('/', {
            templateUrl: 'pages/products.html',
            controller: 'ProductsController'
        })

        .when('/Cart', {
            templateUrl: 'pages/cart.html',
            controller: 'CartController'
        })

        .otherwise({ redirectTo: '/' });
});