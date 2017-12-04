app.controller('AgregarEmpleados', function ($http, $scope) {

    $scope.Empleado = {};

    $scope.SaveItem = function () {
        $http.post('Empleados/AgregarEmpleados', $scope.Empleado).then(function (response) {

            $scope.enviado = response.data;
            $scope.Empleado = {};
          })
    }
  //

});