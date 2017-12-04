app.controller('VentasController', function ($scope, $http) {

        get();
        function get() {
            $http.get('/Ventas/GetCostumers').then(function (response) {

                $scope.clientes = response.data;
                console.log($scope.clientes);

            });
        }
      
    })