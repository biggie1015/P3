app.controller('AgregarProductos', function ($http, $scope) {
    ShowData();
    $scope.producto = {};
    

    $scope.SaveItem = function () {
        $http.post('Productos/AgregarProductos', $scope.producto).then(function (response) {

            $scope.enviado = response.data;
            ShowData();
            $scope.producto = {};


        });
    }

    function ShowData() {

        $http.get('Productos/GetProducts').then(function (response) {

            $scope.products = response.data;

        });
    }

     
  });