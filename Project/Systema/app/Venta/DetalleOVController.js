var DetalleOVController = function ($rootScope, $scope, $modalInstance, $http, ID_Orden, ID_DetalleOrden, Codigo_Producto, Descripcion_Producto, PrecioUnitario, Cantidad, Descuento, Monto, ID_Socio, scope) {


    $scope.New = {
        ID_DetalleOrden: ID_DetalleOrden,
        ID_Orden: ID_Orden,
        Codigo_Producto: Codigo_Producto,
        Descripcion_Producto: Descripcion_Producto,
        PrecioUnitario: PrecioUnitario,
        Cantidad: Cantidad,
        Descuento:Descuento,
        Monto: Monto,
        Total:0,
        ID_Socio: ID_Socio,
        Id_Producto: 0,
        PV: 0,
    }

    $scope.List = function () {


        $http({
            method: 'GET',
            url: 'api/StockWS',
            params: {
                Descripcion: "%",
            }
        }).success(function (response) {
            $scope.StockAdd = response;

            $.each($scope.StockAdd, function (index, value) {
                value.checked = false;

            });

        });

    }

    $scope.ok = function () {

        $http({
            method: 'POST',
            url: 'api/DetalleOrdenVentaWS',
            data: $scope.New,
        }).success(function (response) {

            $scope.New.ID_Orden = response;
            //getProducto($scope.New.ID_Producto);
            alert("Registro Correcto");
            //$state.go('ProductoList');
        });

    }

    $scope.PrecioU = function () {


        $http({
            method: 'GET',
            url: 'api/ProductoWS',
            params: {
                ID_Producto: $scope.New.ID_Producto
            }
        }).success(function (response) {
            $scope.ProductoGet = response;
            $scope.New.PrecioUnitario = item.PV;
            //$scope.New = response;
        });

    }





    $scope.ok = function () {
        modeAction();

    };

    $scope.cancel = function () {

        $modalInstance.dismiss('cancel');
    };


    function modeAction() {

        $http({
            method: 'Post',
            url: 'api/DetalleOrdenVentaWS',
            data: $scope.New,
        }).success(function (response) {
            scope.ListarDetalle();

            $modalInstance.dismiss('cancel');
        });


    }

    //if (ID_DetalleOrden != 0) {
    //    $http({
    //        method: 'Get',
    //        url: 'api/DetalleOrdenCompraWS',
    //        params: {
    //            ID_DetalleOrden: ID_DetalleOrden,
    //            ID_Orden: ID_Orden,
    //        }
    //    }).success(function (responsse) {
    //        $scope.New = responsse;
    //    });

    //}

    $scope.Calcular = function () {

        $scope.New.Monto = $scope.New.PrecioUnitario * $scope.New.Cantidad ;
        $scope.New.Total = $scope.New.Monto - ($scope.New.Monto * ($scope.New.Descuento / 100));




    }

    $scope.Calcular2 = function () {

        $scope.New.Monto = $scope.New.PrecioUnitario * $scope.New.Cantidad;
        $scope.New.Total = $scope.New.Monto - ($scope.New.Monto * ($scope.New.Descuento / 100));



    }
    $scope.List();
}

DetalleOVController.$inject = ['$rootScope', '$scope', '$modalInstance', '$http', 'ID_Orden', 'ID_DetalleOrden', 'Codigo_Producto', 'Descripcion_Producto', 'PrecioUnitario', 'Cantidad', 'Descuento', 'Monto', 'ID_Socio', 'scope'];