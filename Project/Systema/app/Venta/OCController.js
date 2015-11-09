var OCController = function ($rootScope, $scope, $state, $stateParams, $http, $modal) {

    $scope.parameters = {
 
        Nombres_Socio: "",
        FechaInI: "",
        FechaFin: "",
        Descripcion: "",
    }

    $scope.New = {
        ID_Orden: 0,
        ID_Socio: '',
        IGV: "19.00",
        Total: 0,
        Descuento: 0,
        FechaEmision: new Date(),
        FechaEntrega: new Date(),
        FechaContabilidad: new Date(),
        ID_Moneda: '1',
        ID_FormaPago: "",
        ID_CondicionPago: "",
        ID_Surcursal: "",
        SerieDocumento: "",
        NroDocumento: "",
        Estado: "",
        Lista: [],
        ID_Grupo: '',
        Nombres_Socio: "",
        Nro_Documento: '',
        Monto: 0,
        Cantidad: 0,
        Impuesto: 0,
        Codigo_Producto: 0,
        Descripcion_Producto: '',
        PrecioUnitario: 0 ,
        
       
    }

    $scope.New2 = {
        ID_Orden: '',
        PrecioUnitario: '',
        Cantidad: '',
        Monto: '',
        Atendido: 0,
        Faltante: '',
        ID_Producto: '',
        FechaCreacion: new Date(),

        
    }

    $scope.New3 = {
        NumCor: 0,
        DescripcionTab: '',
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
            url: 'api/OrdenCompraWS',
            params: {
               
                Nombres_Socio: $scope.parameters.Nombres_Socio == (null || '') ? "%" : $scope.parameters.Nombres_Socio,
                FechaInI: $scope.parameters.FechaInI == (null || '') ? "01/01/1900" : $scope.parameters.FechaInI,
                FechaFin: $scope.parameters.FechaFin == (null || '') ? "01/01/2200" : $scope.parameters.FechaFin,
                Descripcion: $scope.parameters.Descripcion == (null || '') ? "P" : $scope.parameters.Descripcion
            }
        }).success(function (response) {
            $scope.OrdenList = response;

        });



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
            $scope.Calcular2();
        });
    }

    $scope.DList = function () {
        $http({
            method: 'GET',
            url: 'api/DireccionWS',
            params: {
                ID_Socio: $scope.New.ID_Socio,
            }
        }).success(function (response) {
            $scope.DireccionList = response;
        });
    }

    $scope.TempOC = function () {
        $http({
            method: 'GET',
            url: 'api/TabGenWS',
            params: {
                DescripcionTab: 'DetalleOrdenDeCompra',
            }
        }).success(function (response) {
            $scope.TempOrdenC = response;
            $scope.New3 = response;
            $scope.ActualizarOden();
        });
    }

    $scope.ActualizarOden = function () {
        $http({
            method: 'Delete',
            url: 'api/TabGenWS',
            params: {
                DescripcionTab: 'DetalleOrdenDeCompra',
            }
        }).success(function (response) {

        });

    }

    $scope.Create = function () {
        $('#Id').val('0');
        $('#Action').val('Create');
        $state.go('OCCreate');
    }

    $scope.Cancel = function () {
        $('#Id').val('0');
        $('#Action').val('List');
        $state.go('OCList');

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
                    CodigoTabla: '005',

                }
            }).success(function (response) {
                $scope.FormaList = response;

                $http({
                    method: 'GET',
                    url: 'api/ConceptoWS',
                    params: {
                        CodigoTabla: '006',

                    }
                }).success(function (response) {
                    $scope.CondicionList = response;

                });
            });
        });

    }

    $scope.SaveNew2 = function () {
        $http({
            method: 'POST',
            url: 'api/OrdenCompraWS',
            data: $scope.New,
        }).success(function (response) {
            $scope.New.ID_Orden = response;
            alert("Registro Modificado");
             $scope.Cancel();

        });

    }

     
    $scope.SaveNew = function () {
        $http({
            method: 'POST',
            url: 'api/OrdenCompraWS',
            data: $scope.New,
        }).success(function (response) {
            var Id = response;

            if (Id != 0) {
                for (var i = 0; i < $scope.ProductoList.length; i++) {
                    var item = $scope.ProductoList[i];
                    item.ID_Orden = Id;

                    $http({
                        method: 'POST',
                        url: 'api/DetalleOrdenCompraWS',
                        data: item,
                    }).success(function (response) {

                    });

                }
                
            }
            alert("Registro Correcto");
            $scope.Cancel();
        });
    }


    $scope.Edit = function () {
        $state.go('OCModific');

    }

    $scope.Delete = function () {


    }


    $scope.solcio = function () {
        $http({
            method: 'GET',
            url: 'api/SocioNegocioWS',
            params: {
                
                ID_Socio: $scope.New.ID_Socio,
            }

        }).success(function (response) {
            $scope.SocioNegocioList = response;

        });

    }
    if ($('#Id').val() != '0') {   //Editar

        $http({
            method: 'GET',
            url: 'api/OrdenCompraWS',
            params: {

                ID_Orden: $('#Id').val(),

            }
        }).success(function (response) {
           
            Loadddl();
            $scope.New = response;
            $scope.DList();
            $scope.solcio();
            $scope.ListarDetalle();
 
        });
    } else {                

    }






    $scope.select = function (id) {
        $('#Id').val(id);


    }

    $scope.deleteDetalle = function (Id) {
        $http({
            method: 'Delete',
            url: 'api/DetalleOrdenCompraWS',
            params: {
                ID_DetalleOrden: Id,
            }
        }).success(function (response) {
            $scope.ListarDetalle();
            alert("Registro Eliminado");
        });

    }

    $scope.editDetalle = function (Id,CodProducto,DespProducto,PUnitario,ICantidad,IMonto,Empresa) {
        var modalInstance = $modal.open({
            templateUrl: '/DetalleOC/Modific',
            controller: 'DetalleOCController',
            resolve: {
                ID_Orden: function () {
                    return $scope.New.ID_Orden;
                },
                ID_DetalleOrden: function () {
                    return Id;
                },
                Codigo_Producto: function () {
                    return CodProducto;
                },
                Descripcion_Producto: function () {
                    return DespProducto;
                },
                PrecioUnitario: function () {
                    return PUnitario;
                },
                Cantidad: function () {
                    return ICantidad;
                },
                Monto: function () {
                    return IMonto;
                },
                ID_Socio: function () {
                    return Empresa;
                },
                scope: function () {
                    return $scope;
                }

            }
        });
       
    }

    $scope.editDetalle2 = function (Id, CodProducto, DespProducto, PUnitario, ICantidad, IMonto, Empresa) {
        var modalInstance = $modal.open({
            templateUrl: '/DetalleOC/Create',
            controller: 'DetalleOCController',
            resolve: {
                ID_Orden: function () {
                    return $scope.New.ID_Orden;
                },
                ID_DetalleOrden: function () {
                    return Id;
                },
                Codigo_Producto: function () {
                    return CodProducto;
                },
                Descripcion_Producto: function () {
                    return DespProducto;
                },
                PrecioUnitario: function () {
                    return PUnitario;
                },
                Cantidad: function () {
                    return ICantidad;
                },
                Monto: function () {
                    return IMonto;
                },
                ID_Socio: function () {
                    return $scope.New.ID_Socio;
                },
                scope: function () {
                    return $scope;
                }

            }
        });

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


    $scope.addItem = function () {

        var modalInstance = $modal.open({
            templateUrl: '/Producto/ListAdd',
            controller: 'ProductoAddController',
            resolve: {
                scope: function () {
                    return $scope;
                }
            }
        });
    }

 
    $scope.addDescuento = function (Id) {
        var modalInstance = $modal.open({
            templateUrl: '/Descuento/ListAdd',
            controller: 'DescuentoAddController',
            resolve: {
                scope: function () {
                    return $scope;
                },
                Id: function () {
                    return Id;
                }

            }
        });
    }

    $scope.getdetalle = function (lista) {
        $scope.ProductoList = lista;
        $.each($scope.ProductoList, function (index, value) {
            value.IGV = "19%"
            value.PrecioUnitario = value.PC;
            value.Cantidad = 1;
            value.PorcDscto = 0;
            value.Monto = value.PrecioUnitario * value.Cantidad;
        });

        $scope.Calcular();
    }

   
    $scope.getdescuento = function (item) {

        $.each($scope.ProductoList, function (index, value) {
            if (value.ID_Producto == item.ID_Producto) {
                value.PorcDscto = item.PorcDscto;

            }
        });

        $scope.Calcular();
    }




    $scope.getsocio = function (item) {
        $scope.New.ID_Socio = item.ID_Socio;
        $scope.New.Nombres_Socio = item.Nombres_Socio;
        $scope.DList();
        $scope.TempOC();

    }

    function NumberDecimal(number) {
        return parseFloat(number);
    }

    function NumberInt(number) {
        return parseInt(number);
    }

    $scope.Calcular = function () {
        $scope.New.Monto = 0
        
        //$scope.New.Impuesto = 0;
        $.each($scope.ProductoList, function (index, value) {


            value.Monto = (NumberDecimal(value.PrecioUnitario) * NumberInt(value.Cantidad));

            $scope.New.Monto += value.Monto
            $scope.New.Impuesto = (NumberInt($scope.New.IGV) / 100) * $scope.New.Monto;
            $scope.New.Total = $scope.New.Monto + $scope.New.Impuesto - $scope.New.Descuento;

        });

    }

    $scope.Calcular2 = function () {
        $scope.New.Monto = 0
      //$scope.New.Impuesto = 0;

        $.each($scope.DetalleOrdenCompraList, function (index, value) {

            //value.Monto = (NumberDecimal(value.PrecioUnitario) * NumberInt(value.Cantidad));

            $scope.New.Monto += value.Monto
            $scope.New.Impuesto = (NumberInt($scope.New.IGV) / 100) * $scope.New.Monto;
            $scope.New.Total = $scope.New.Monto + $scope.New.Impuesto - $scope.New.Descuento;

        });

    }

    

    $scope.List();

    Loadddl();



}
OCController.$inject = ['$rootScope', '$scope', '$state', '$stateParams', '$http', '$modal'];