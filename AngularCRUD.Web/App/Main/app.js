(function () {
    'use strict';

    var app = angular.module('app', [
        'ngAnimate',
        'ngSanitize',
        'ui.router',
        'ui.bootstrap',
        'ui.jq',
        'abp'
    ]);

    //Configuration for Angular UI routing.
    app.config([
        '$stateProvider', '$urlRouterProvider',
        function($stateProvider, $urlRouterProvider) {
            $urlRouterProvider.otherwise('/');
            $stateProvider
                .state('home', {
                    url: '/',
                    templateUrl: '/App/Main/views/home/home.cshtml',
                    menu: 'Home' //Matches to name of 'Home' menu in AngularCRUDNavigationProvider
                })
                .state('persons', {
                    url: '/admin/persons',
                    templateUrl: '/App/Main/views/admin/persons/persons.cshtml',
                    menu: 'menu_admin_persons'
                });
        }
    ]);
})();