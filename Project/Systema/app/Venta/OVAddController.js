var OVAddController = function ($rootScope, $scope, $modalInstance, $http, $modal, ID_Socio, scope) {


    $scope.parameters = {


        FechaInI: "",
        FechaFin: "",

    }

    $scope.Item = {
        ID_Orden: 0,
    }

    $scope.New = {
        ID_Socio: ID_Socio,
        Estado: '',
    }

    $scope.ListOrden = function () {


        $http({
            method: 'GET',
            url: 'api/OrdenVentaWS',
            params: {

                ID_Socio: ID_Socio,
                FechaInI: $scope.parameters.FechaInI == (null || '') ? "01/01/1900" : $scope.parameters.FechaInI,
                FechaFin: $scope.parameters.FechaFin == (null || '') ? "01/01/2200" : $scope.parameters.FechaFin,
                Estado: 'A'
            }
        }).success(function (response) {
            $scope.OrdenVentaListPorFecha = response;

        });



    }

    $scope.dateOptions = {
        formatYear: 'yy',
        startingDay: 1,
        showWeeks: false
    };

    $scope.open = function ($event) {
        $event.preventDefault();
        $event.stopPropagation();

        $scope.opened = true;


    };

    $scope.open1 = function ($event) {
        $event.preventDefault();
        $event.stopPropagation();

        $scope.opened1 = true;


    };

    $scope.Select = function (item) {
        $.each($scope.OrdenVentaListPorFecha, function (index, value) {
            if (value.ID_Orden != item.ID_Orden) {
                value.checked = false;
            } else {
                value.checked = true;
                $scope.Item.ID_Orden = item.ID_Orden;


            }
        });

    }


    $scope.cancel = function () {

        $modalInstance.dismiss('cancel');
    };

    $scope.ok = function () {

        modeAction();

    };

    function modeAction() {
        if ($scope.Item.ID_Orden != 0) {

            scope.getOrdenCompra2($scope.Item);
            $modalInstance.dismiss('cancel');


        } else {

            alert("No selecciono Item");
        }

    }

    //////$scope.List = function () {


    //////    $http({
    //////        method: 'GET',
    //////        url: 'api/ProductoWS',
    //////        params: {
    //////            Descripcion: "%",
    //////            ID_Socio: ID_Socio
    //////        }
    //////    }).success(function (response) {
    //////        $scope.ProductoList = response;

    //////        $.each($scope.ProductoList, function (index, value) {
    //////            value.checked = false;

    //////        });

    //////    });

    //////}

    ////$scope.ok = function () {

    ////    $http({
    ////        method: 'POST',
    ////        url: 'api/DetalleOrdenCompraWS',
    ////        data: $scope.New,
    ////    }).success(function (response) {

    ////        $scope.New.ID_Orden = response;
    ////        //getProducto($scope.New.ID_Producto);
    ////        alert("Registro Correcto");
    ////        //$state.go('ProductoList');
    ////    });

    ////}





    ////$scope.ok = function () {
    ////    modeAction();

    ////};



    ////function modeAction() {

    ////    $http({
    ////        method: 'Post',
    ////        url: 'api/DetalleOrdenCompraWS',
    ////        data: $scope.New,
    ////    }).success(function (response) {
    ////        scope.ListarDetalle();

    ////        $modalInstance.dismiss('cancel');
    ////    });


    ////}



    ////$scope.List();
    $scope.ListOrden();
}

OVAddController.$inject = ['$rootScope', '$scope', '$modalInstance', '$http', '$modal', 'ID_Socio', 'scope'];
