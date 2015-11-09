var RequerimientosController = function ($rootScope, $scope, $state, $stateParams, $http, $modal) {
    $scope.parameters = {
        Nombres_Socio: "",
        FechaInI: "",
        FechaFin: "",
    }

    $scope.New = {
        ID_Requerimientos: 0,
        ID_Orden: '',
        ID_Socio: '',
        FechaContabilidad: new Date(),
        FechaEmision: new Date(),
        FechaEntrega: new Date(),
        Lista: [],
        Estado: '',
        Monto: 0,
        Cantidad: 0,
        Impuesto: 0,
        Codigo_Producto: 0,
        Descripcion_Producto: '',
        PrecioUnitario: 0,
        Lote: 0,
        NroDocumento: 0,
        TipoDocumento:0,


    }

    $scope.Edit = function () {
        $state.go('RequerimientosModific');

    }



    $scope.select = function (id) {
        $('#Id').val(id);


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

    $scope.open2 = function ($event) {
        $event.preventDefault();
        $event.stopPropagation();

        $scope.opened2 = true;


    };

    $scope.List = function () {


        $http({
            method: 'GET',
            url: 'api/RequerimientosWS',
            params: {
                Nombres_Socio: $scope.parameters.Nombres_Socio == (null || '') ? "%" : $scope.parameters.Nombres_Socio,
                FechaInI: $scope.parameters.FechaInI == (null || '') ? "01/01/1900" : $scope.parameters.FechaInI,
                FechaFin: $scope.parameters.FechaFin == (null || '') ? "01/01/2200" : $scope.parameters.FechaFin,
                            }
        }).success(function (response) {
            $scope.RequerimientoList = response;

        });



    }

    $scope.ListarDetalle = function () {

        $http({
            method: 'GET',
            url: 'api/DetalleRequerimientoWS',
            params: {
                ID_Orden: $scope.New.ID_Orden,
            }
        }).success(function (response) {
            $scope.DetalleRequerimientoList = response;
            $scope.Calcular2();
        });
    }
 
    $scope.AList = function () {
        $http({
            method: 'GET',
            url: 'api/AlmacenWS',
            params: {
                Descripcion_Almacen: '%',
             
            }
        }).success(function (response) {
            $scope.AlmacenList = response;
        });
    }

  
    $scope.addOrdenNew = function () {

        if ($scope.New.ID_Socio != 0) {

            var modalInstance = $modal.open({
                templateUrl: '/OVAdd/ListAdd',
                controller: 'OVAddController',

                resolve: {
                    ID_Socio: function () {
                        return $scope.New.ID_Socio;
                    },
                    scope: function () {
                        return $scope;
                    }

                }
            });

        } else {

            alert("Seleccione un Cliente");
        }


    }


    $scope.addSocio = function () {

        var modalInstance = $modal.open({
            templateUrl: '/SocioNegocio/ListAddCliente',
            controller: 'SocioNegocioAddClienteController',
            resolve: {
                scope: function () {
                    return $scope;
                }
            }
        });
    }


    $scope.Create = function () {
        $('#Id').val('0');
        $('#Action').val('Create');
        $state.go('RequerimientosCreate');
    }

    $scope.Cancel = function () {
        $('#Id').val('0');
        $('#Action').val('List');
        $state.go('RequerimientoList');

    }

    //$scope.SaveNew = function () {
    //    $http({
    //        method: 'POST',
    //        url: 'api/RequerimientosWS',
    //        data: $scope.New,
    //    }).success(function (response) {
    //        $scope.New.Requerimiento = response;
    //        alert("Registro Correcto");


    //    });

    //}

    $scope.ActualizarOden = function () {
        $http({
            method: 'Delete',
            url: 'api/OrdenVentaWS',
            params: {
                ID_Orden: $scope.New.ID_Orden,
            }
        }).success(function (response) {

        });

    }

    $scope.SaveNew = function () {
        $http({
            method: 'POST',
            url: 'api/RequerimientosWS',
            data: $scope.New,
        }).success(function (response) {
            var Id = response;

            if (Id != 0) {
                for (var i = 0; i < $scope.DetalleOrdenVentaList.length; i++) {
                    var item = $scope.DetalleOrdenVentaList[i];
                    item.ID_Requerimientos = Id;
                   
                    $http({
                        method: 'POST',
                        url: 'api/DetalleRequerimientosWS',
                        data: item,
                    }).success(function (response) {

                    });

                    $http({
                        method: 'Delete',
                        url: 'api/DetalleRequerimientosWS',
                        params: {
                            Atendido: item.CantidadRequisito,
                            Faltante: item.Faltante,
                            ID_DetalleOrden: item.ID_DetalleOrden,
                        }
                    }).success(function (response) {

                    });

                    $http({
                        method: 'POST',
                        url: 'api/StockWS',
                        params: {
                            Id_Producto: item.ID_Producto,
                            Codigo_Producto: item.Codigo_Producto,
                            CodigoDif: "A",
                            Lote: item.Lote_Requermientos,
                            Cantidad: item.CantidadRequisito,
                        }
                    }).success(function (response) {

                    });
                   
                    $http({
                        method: 'Delete',
                        url: 'api/OrdenVentaWS',
                        params: {
                            ID_Orden: $scope.New.ID_Orden,
                        }
                    }).success(function (response) {

                    });
                }

            }
            //$scope.ActualizarOden();
            alert("Registro Correcto");
            $scope.Cancel();
        });
    }

    $scope.Edit = function () {
        $state.go('RequerimientosCreate');
    }

    $scope.Edit = function () {

        $state.go('RequerimientosCreate');
    }


    if ($('#Id').val() != '0') {   //Editar

        $http({
            method: 'GET',
            url: 'api/RequerimientosWS',
            params: {

                ID_Requerimientos: $('#Id').val(),

            }
        }).success(function (response) {
            $scope.New = response;
            $scope.AList();
            $scope.ListarDetalle();
        });
    } else {                      //Crear

    }

    $scope.select = function (id) {
        $('#Id').val(id);
    }


    $scope.Delete = function () {


    }
    

 
    $scope.select = function (id) {
        $('#Id').val(id);


    }


    $scope.getsocio = function (item) {
        $scope.New.ID_Socio = item.ID_Socio;
        
    }

    $scope.getOrdenVenta = function (item) {
        $scope.New.ID_Orden = item.ID_Orden;
        $scope.ListarDetalle();

    }

    $scope.ListarDetalle = function () {

        $http({
            method: 'GET',
            url: 'api/DetalleOrdenVentaWS',
            params: {
                ID_Orden: $scope.New.ID_Orden,
            }
        }).success(function (response) {
            $scope.DetalleOrdenVentaList = response;
            var lista = [];
            $.each($scope.DetalleOrdenVentaList, function (index, value) {
                    lista.push(value);
               
            });
            ffff(lista);

        });
    }

    function ffff(lista) {
        $scope.getdetalle(lista);
    }

    $scope.getdetalle = function (lista) {
        $scope.DetalleOrdenVentaList = lista;
        $.each($scope.DetalleOrdenVentaList, function (index, value) {
            value.CantidadRequisito = 0;
            value.Faltante = value.Cantidad - value.Atendido - value.CantidadRequisito;
        });

        $scope.Calcular();
    }
   
    $scope.Calcular = function () {
        $scope.New.Faltante = 0

        //$scope.New.Impuesto = 0;
        $.each($scope.DetalleOrdenVentaList, function (index, value) {

            value.Faltante = value.Cantidad - value.Atendido - value.CantidadRequisito;

        });

    }
    
    function Loadddl() {
        $http({
            method: 'GET',
            url: 'api/ConceptoWS',
            params: {
                CodigoTabla: '004',

            }
        }).success(function (response) {
            $scope.MonedaList = response;
            $http({
                method: 'GET',
                url: 'api/ConceptoWS',
                params: {
                    CodigoTabla: '013',

                }
            }).success(function (response) {
                $scope.FormaList = response;

                $http({
                    method: 'GET',
                    url: 'api/ConceptoWS',
                    params: {
                        CodigoTabla: '013',

                    }
                }).success(function (response) {
                    $scope.CondicionList = response;

                });
            });
        });

    }

    $scope.List();
    Loadddl();
    $scope.AList();
}

RequerimientosController.$inject = ['$rootScope', '$scope', '$state', '$stateParams', '$http', '$modal'];