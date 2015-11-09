var MovimientoController = function ($rootScope, $scope, $state, $stateParams, $http, $modal) {
    $scope.parameters = {
        Nombres_Socio: "",
        FechaInI: "",
        FechaFin: "",
    }

    $scope.New = {
        ID_Movimiento: 0,
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
        Lote_Movimiento: 0,
        NroDocumento: 0,
        TipoDocumento:0,
        Tipo_Movimiento: '',
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
            url: 'api/MovimientoWS',
            params: {
                Nombres_Socio: $scope.parameters.Nombres_Socio == (null || '') ? "%" : $scope.parameters.Nombres_Socio,
                FechaInI: $scope.parameters.FechaInI == (null || '') ? "01/01/1900" : $scope.parameters.FechaInI,
                FechaFin: $scope.parameters.FechaFin == (null || '') ? "01/01/2200" : $scope.parameters.FechaFin,
                Tipo_Movimiento: "E"
                            }
        }).success(function (response) {
            $scope.NotaIngresoList = response;

        });



    }
    $scope.List2 = function () {


        $http({
            method: 'GET',
            url: 'api/MovimientoWS',
            params: {
                Nombres_Socio: $scope.parameters.Nombres_Socio == (null || '') ? "%" : $scope.parameters.Nombres_Socio,
                FechaInI: $scope.parameters.FechaInI == (null || '') ? "01/01/1900" : $scope.parameters.FechaInI,
                FechaFin: $scope.parameters.FechaFin == (null || '') ? "01/01/2200" : $scope.parameters.FechaFin,
            }
        }).success(function (response) {
            $scope.NotaIngresoList2 = response;

        });



    }



    $scope.AList = function () {
        $http({
            method: 'GET',
            url: 'api/AlmacenWS',
            params: {
                Descripcion_Almacen: '%',
                Estado: 'A',
            }
        }).success(function (response) {
            $scope.AlmacenList = response;
        });
    }

  
    $scope.addOrdenNew = function () {

        if ($scope.New.ID_Socio != 0) {

            var modalInstance = $modal.open({
                templateUrl: '/OCAdd/ListAdd',
                controller: 'OCAddController',

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

            alert("Seleccione un Proveedor");
        }


    }
    $scope.addOrdenNew2 = function () {

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

            alert("Seleccione un Proveedor");
        }


    }
    $scope.addSocio = function () {

        var modalInstance = $modal.open({
            templateUrl: '/SocioNegocio/ListAdd',
            controller: 'SocioNegocioAddController',
            resolve: {
                scope: function () {
                    return $scope;
                }
            }
        });
    }

    $scope.addSocio2 = function () {

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
        $state.go('MovimientoCreate');

    }

    $scope.Create2 = function () {
        $('#Id').val('0');
        $('#Action').val('Create2');
        $state.go('MovimientoCreate2');

    }

    $scope.Cancel = function () {
        $('#Id').val('0');
        $('#Action').val('List');
        $state.go('MovimientoList');

    }
    $scope.Cancel2 = function () {
        $('#Id').val('0');
        $('#Action').val('List2');
        $state.go('MovimientoList2');

    }

    //$scope.SaveNew = function () {
    //    $http({
    //        method: 'POST',
    //        url: 'api/MovimientoWS',
    //        data: $scope.New,

    //    }).success(function (response) {
    //        $scope.New.Movimiento = response;
    //        alert("Registro Correcto");


    //    });

    //}

    $scope.ActualizarOden = function () {
        $http({
            method: 'Delete',
            url: 'api/OrdenCompraWS',
            params: {
                ID_Orden: $scope.New.ID_Orden,
            }
        }).success(function (response) {

        });

    }

    $scope.SaveNew = function () {
        $scope.New.Tipo_Movimiento = 'E';


        $http({
            method: 'POST',
            url: 'api/MovimientoWS',
            data: $scope.New,
            
        }).success(function (response) {
            var Id = response;

            if (Id != 0) {
                for (var i = 0; i < $scope.DetalleOrdenCompraList.length; i++) {
                    var item = $scope.DetalleOrdenCompraList[i];
                    item.ID_Movimiento = Id;
                    item.Tipo_Movimiento = 'E';
                    $http({
                        method: 'POST',
                        url: 'api/DetalleMovimientoWS',
                        data: item,
                    }).success(function (response) {

                    });

                    $http({
                        method: 'Delete',
                        url: 'api/DetalleMovimientoWS',
                        params: {
                            Atendido: item.CantidadMovimiento,
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
                            Lote: item.Lote_Movimiento,
                            Cantidad: item.CantidadMovimiento,
                        }
                    }).success(function (response) {

                    });
                   
                    $http({
                        method: 'Delete',
                        url: 'api/OrdenCompraWS',
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



    $scope.SaveNew2 = function () {
        $scope.New.Tipo_Movimiento = 'S';
        $http({
            method: 'POST',
            url: 'api/MovimientoWS',
            data: $scope.New,
        }).success(function (response) {
            var Id = response;

            if (Id != 0) {
                for (var i = 0; i < $scope.DetalleOrdenVentaList.length; i++) {
                    var item = $scope.DetalleOrdenVentaList[i];
                    item.ID_Movimiento = Id;
                    item.Tipo_Movimiento = 'S';
                    $http({
                        method: 'POST',
                        url: 'api/DetalleMovimientoWS',
                        data: item,
                    }).success(function (response) {

                    });

                    $http({
                        method: 'Delete',
                        url: 'api/DetalleOrdenVentaWS',
                        params: {
                            Atendido: item.CantidadMovimiento,
                            Faltante: item.Faltante,
                            ID_DetalleOrden: item.ID_DetalleOrden,
                        }
                    }).success(function (response) {

                    });

                    $http({
                        method: 'Delete',
                        url: 'api/StockWS',
                        params: {
                            Id_Producto: item.ID_Producto,
                            Codigo_Producto: item.Codigo_Producto,
                            CodigoDif: "A",
                            Lote: item.Lote,
                            Cantidad: item.CantidadMovimiento,
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
            $scope.Cancel2();
        });
    }



    $scope.Edit = function () {
        $state.go('MovimientoCreate');
    }

    $scope.Edit = function () {

        $state.go('MovimientoCreate');
    }


    if ($('#Id').val() != '0') {   //Editar

        $http({
            method: 'GET',
            url: 'api/MovimientoWS',
            params: {

                ID_NotaIngreso: $('#Id').val(),

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

    $scope.getOrdenCompra = function (item) {
        $scope.New.ID_Orden = item.ID_Orden;
        $scope.ListarDetalle();

    }

    $scope.ListarDetalle = function () {

        $http({
            method: 'GET',
            url: 'api/DetalleOrdenCompraWS',
            params: {
                ID_Orden: $scope.New.ID_Orden,
            }
        }).success(function (response) {
            $scope.DetalleOrdenCompraList = response;
            var lista = [];
            $.each($scope.DetalleOrdenCompraList, function (index, value) {
                    lista.push(value);
               
            });
            ffff(lista);

        });
    }

    function ffff(lista) {
        $scope.getdetalle(lista);
    }

    $scope.getOrdenCompra2 = function (item) {
        $scope.New.ID_Orden = item.ID_Orden;
        $scope.ListarDetalle2();

    }

    $scope.ListarDetalle2 = function () {

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
            ffff2(lista);

        });
    }

    function ffff2(lista) {
        $scope.getdetalle2(lista);
    }

    $scope.getdetalle2 = function (lista) {
        $scope.DetalleOrdenVentaList = lista;
        $.each($scope.DetalleOrdenVentaList, function (index, value) {
            value.CantidadMovimiento = 0;
            value.Faltante = value.Cantidad - value.Atendido - value.CantidadMovimiento;
        });

        $scope.Calcular2();
    }

    $scope.getdetalle = function (lista) {
        $scope.DetalleOrdenCompraList = lista;
        $.each($scope.DetalleOrdenCompraList, function (index, value) {
            value.CantidadMovimiento = 0;
            value.Faltante = value.Cantidad - value.Atendido - value.CantidadMovimiento;
        });

        $scope.Calcular();
    }
   
    $scope.Calcular2 = function () {
        $scope.New.Faltante = 0

        //$scope.New.Impuesto = 0;
        $.each($scope.DetalleOrdenVentaList, function (index, value) {

            value.Faltante = value.Cantidad - value.Atendido - value.CantidadMovimiento;

        });

    }


    $scope.Calcular = function () {
        $scope.New.Faltante = 0

        //$scope.New.Impuesto = 0;
        $.each($scope.DetalleOrdenCompraList, function (index, value) {

            value.Faltante = value.Cantidad - value.Atendido - value.CantidadMovimiento;

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
    $scope.List2();
    Loadddl();
    $scope.AList();
}

MovimientoController.$inject = ['$rootScope', '$scope', '$state', '$stateParams', '$http', '$modal'];