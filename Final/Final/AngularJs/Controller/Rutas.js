var app = angular.module('app', ['ngRoute'])
app.config(function ($routeProvider, $locationProvider) {

        $routeProvider
            .when('/', {

                templateUrl: 'AngularJs/Template/Inicio.html'

            })
            .when('/clientes', {

                templateUrl: 'AngularJs/Template/Clientes.html',
                controller : 'AgregarClientes'

        })

            .when('/empleado', {

                templateUrl: 'AngularJs/Template/Empleado.html',
                controller: 'AgregarEmpleados'

        })
            .when('/producto', {

                templateUrl: 'AngularJs/Template/producto.html',
                controller: 'AgregarProductos'

        })
            .when('/venta', {

                templateUrl: 'AngularJs/Template/Ventas.html',
                controller:'VentasController'

            });


            
        $locationProvider.html5Mode(true);

    });