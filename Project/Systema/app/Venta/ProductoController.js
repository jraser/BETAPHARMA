var ProductoController = function ($rootScope, $scope, $state, $stateParams, $http, $modal) {

    $scope.parameters = {
        Descripcion: "",
    }

    $scope.p2arameters = {
        Descripcion_P: "",
        ID_Categoria: "",
        ID_SubCategoria: "",
        ID_Socio:"",

    }

    $scope.New = {
        ID_Producto: 0,
        Codigo_Producto: '',
        ID_Marca: null,
        ID_Categoria: null,
        ID_SubCategoria: null,
        Descripcion_Producto: '',
        Precio_CompBase: '',
        Precio_VenBase: '',
        CostoProducto: 0,
        Codigo_UMedida: "",
    }

   



    $scope.List = function () {


        $http({
            method: 'GET',
            url: 'api/ProductoWS',
            params: {
                Descripcion: $scope.parameters.Descripcion == (null || '') ? "%" : $scope.parameters.Descripcion,

            }
        }).success(function (response) {
            $scope.ProductoList = response;

        });
    }


    $scope.ListPrecios = function () {

        $http({
            method: 'GET',
            url: 'api/ProductoWS',
            params: {
                Descripcion_Producto: $scope.p2arameters.Descripcion_Producto == (null || '') ? "%" : $scope.p2arameters.Descripcion_Producto,
                ID_Categoria: $scope.p2arameters.ID_Categoria == (null || '') ? "%" : $scope.p2arameters.ID_Categoria,
                ID_SubCategoria: $scope.p2arameters.ID_SubCategoria == (null || '') ? "%" : $scope.p2arameters.ID_SubCategoria,
                ID_Socio: $scope.p2arameters.ID_Socio == (null || '') ? "%" : $scope.p2arameters.ID_Socio,
              
            }
        }).success(function (response) {
            $scope.ProductoBySocioList = response;

        });
    }





    $scope.ListMarca = function () {
        $http({
            method: 'GET',
            url: 'api/MarcaWS',
        }).success(function (response) {
            $scope.MarcaList = response;
        });

    }

    $scope.ListCategoria = function () {
        $http({
            method: 'GET',
            url: 'api/CategoriaWS',
        }).success(function (response) {
            $scope.CategoriaList = response;

            $http({
                method: 'GET',
                url: 'api/UnidadMedidaWS',
            }).success(function (response) {
                $scope.UnidadList = response;
            });


        });

    }

    $scope.Loadddl = function () {

        $http({
            method: 'GET',
            url: 'api/MarcaWS',
        }).success(function (response) {
            $scope.MarcaList = response;

            $scope.ListCategoria();

        });


    }

    $scope.SelectCategoria = function () {
        $http({
            method: 'GET',
            url: 'api/SubCategoriaWS',
            params: {
                ID_Categoria: $scope.New.ID_Categoria == (null || 0) ? "%" : $scope.New.ID_Categoria,

            }
        }).success(function (response) {
            $scope.SubCategoriaList = response;

        });


    }



    $scope.ListarPrecio = function () {

        $http({
            method: 'GET',
            url: 'api/PrecioWS',
            params: {
                ID_Producto: $scope.New.ID_Producto,
            }
        }).success(function (response) {
            $scope.PrecioList = response;
        });
    }

    $scope.Create = function () {
        $('#Id').val('0');
        $state.go('ProductoCreate');
    }

    $scope.Cancel = function () {
        $('#Id').val('0');

        $state.go('ProductoList');

    }

    $scope.List();
    $scope.ListPrecios();
    $scope.Loadddl();





    function getProducto(Id) {
        $http({
            method: 'Get',
            url: 'api/ProductoWS',
            params: {
                ID_Producto: Id,
            }
        }).success(function (responsse) {
            $http({
                method: 'GET',
                url: 'api/SubCategoriaWS',
                params: {
                    ID_Categoria: responsse.ID_Categoria == (null || 0) ? "%" : responsse.ID_Categoria,
                }
            }).success(function (response) {
                $scope.SubCategoriaList = response;
                $scope.New = responsse;
                $scope.ListarPrecio();


            });
        });
    }



    $scope.SaveNew = function () {

        $http({
            method: 'POST',
            url: 'api/ProductoWS',
            data: $scope.New,
        }).success(function (response) {

            $scope.New.ID_Producto = response;
            //getProducto($scope.New.ID_Producto);
            alert("Registro Correcto");

            $scope.addPrecio();

            //$state.go('ProductoList');
        });

    }

    $scope.Edit = function () {
        $state.go('ProductoCreate');
    }

    $scope.Delete = function () {
        $http({
            method: 'Delete',
            url: 'api/ProductoWS',
            params: {
                ID_Producto: $('#Id').val(),
            }
        }).success(function (response) {
            $scope.List();
        });

    }

    if ($('#Id').val() != '0') {   //Editar

        getProducto($('#Id').val());

    } else {                      //Crear

    }

    $scope.select = function (id) {
        $('#Id').val(id);


    }
    $scope.addPrecio = function () {

        if ($scope.New.ID_Producto != 0) {

            var modalInstance = $modal.open({
                templateUrl: '/Precio/Create',
                controller: 'PrecioController',

                resolve: {
                    ID_Producto: function () {
                        return $scope.New.ID_Producto;
                    },
                    ID_Precio: function () {
                        return 0;
                    },
                    scope: function () {
                        return $scope;
                    }

                }
            });

        } else {

            alert("Ingrese Producto");
        }


    }

    $scope.editPrecio = function (Id) {
        var modalInstance = $modal.open({
            templateUrl: '/Precio/Create',
            controller: 'PrecioController',
            resolve: {
                ID_Producto: function () {
                    return $scope.New.ID_Producto;
                },
                ID_Precio: function () {
                    return Id;
                },
                scope: function () {
                    return $scope;
                }

            }
        });
    }


    $scope.addMarca = function () {

        var modalInstance = $modal.open({
            templateUrl: '/Marca/MarcaAdd',
            controller: 'MarcaAddController',
            resolve: {
                scope: function () {
                    return $scope;
                }
            }
        });
    }

    $scope.addCategoria = function () {

        var modalInstance = $modal.open({
            templateUrl: '/Categoria/CreateAdd',
            controller: 'CategoriaAddController',
            resolve: {
                scope: function () {
                    return $scope;
                }
            }
        });
    }

    $scope.addSubCategoria = function () {
        if ($scope.New.ID_Categoria != null) {

            var modalInstance = $modal.open({
                templateUrl: '/SubCategoria/CreateAdd',
                controller: 'SubCategoriaAddController',
                resolve: {
                    scope: function () {
                        return $scope;
                    }
                }
            });
        } else {
            alert("Seleccione Categoria");
        }

    }


}
ProductoController.$inject = ['$rootScope', '$scope', '$state', '$stateParams', '$http', '$modal'];