app.controller('AgregarClientes', function ($scope, $http) {

        $scope.cliente = {};

        $scope.SaveItem = function () {
            $http.post('Clientes/AgregarClientes', $scope.cliente)
                .then(function (reponse) {
                    $scope.enviado = reponse.data;
                    $scope.cliente = {};
                }, function (error) {

                    console.log(error);
                })

           
        }

    });