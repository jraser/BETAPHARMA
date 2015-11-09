var ListaPrecioController = function ($rootScope, $scope, $state, $stateParams, $http, $modal) {

    $scope.parameters = {
        Descripcion_Producto: "",
        Nombre: "",
        Nombres_Socio: "",
    

    }

    $scope.List = function () {

        $http({
            method: 'GET',
            url: 'api/ListaPrecioWS',
            params: {
                Descripcion_Producto: $scope.parameters.Descripcion_Producto == (null || '') ? "%" : $scope.parameters.Descripcion_Producto,
                Nombre: $scope.parameters.Nombre == (null || '') ? "%" : $scope.parameters.Nombre,
                Nombres_Socio: $scope.parameters.Nombres_Socio == (null || '') ? "%" : $scope.parameters.Nombres_Socio,
            }
        }).success(function (response) {
            $scope.ALTProductoBySocioList = response;

        });
    }


    //$scope.ListMarca = function () {
    //    $http({
    //        method: 'GET',
    //        url: 'api/MarcaWS',
    //    }).success(function (response) {
    //        $scope.MarcaList = response;
    //    });

    //}

    $scope.Loadddl = function () {

        $http({
            method: 'GET',
            url: 'api/MarcaWS',
        }).success(function (response) {
            $scope.MarcaList = response;

            $scope.SocioNegocioList();
            $scope.CategoriaList();

        });
    }

    $scope.SocioNegocioList = function () {
        $http({
            method: 'GET',
            url: 'api/SocioNegocioWS',
        }).success(function (response) {
            $scope.SocioNegocioList = response;

        });

    }


    $scope.CategoriaList = function () {
        $http({
            method: 'GET',
            url: 'api/CategoriaWS',
        }).success(function (response) {
            $scope.CategoriaList = response;

        });

    }


    $scope.Loadddl();
    $scope.List();









    //if ($('#Id').val() != '0') {   //Editar

    //    return $http({
    //        method: 'GET',
    //        url: 'api/CategoriaWS',
    //    }).success(function (response) {
    //        $scope.CategoriaList = response;

    //        $http({
    //            method: 'GET',
    //            url: 'api/SubCategoriaWS',
    //            params: {
    //                ID_SubCategoria: $('#Id').val(),
    //            }
    //        }).success(function (response) {
    //            $scope.New = response;

    //        });
    //    });






    //} else {
    //    return $http({
    //        method: 'GET',
    //        url: 'api/CategoriaWS',
    //    }).success(function (response) {
    //        $scope.CategoriaList = response;
    //    });


    //}
  

    /////////////////////////////////////////////////////



    //$scope.SelectCategoria = function () {
    //    $http({
    //        method: 'GET',
    //        url: 'api/SubCategoriaWS',
    //        params: {
    //            ID_Categoria: $scope.New.ID_Categoria == (null || 0) ? "%" : $scope.New.ID_Categoria,

    //        }
    //    }).success(function (response) {
    //        $scope.SubCategoriaList = response;

    //    });
    //}



    //$scope.ListarPrecio = function () {

    //    $http({
    //        method: 'GET',
    //        url: 'api/PrecioWS',
    //        params: {
    //            ID_Producto: $scope.New.ID_Producto,
    //        }
    //    }).success(function (response) {
    //        $scope.PrecioList = response;
    //    });
    //}


    //$scope.Create = function () {
    //    $('#Id').val('0');
    //    $state.go('ProductoCreate');
    //}

    //$scope.Cancel = function () {
    //    $('#Id').val('0');

    //    $state.go('ProductoList');

    //}



    //function getProducto(Id) {
    //    $http({
    //        method: 'Get',
    //        url: 'api/ProductoWS',
    //        params: {
    //            ID_Producto: Id,
    //        }
    //    }).success(function (responsse) {
    //        $http({
    //            method: 'GET',
    //            url: 'api/SubCategoriaWS',
    //            params: {
    //                ID_Categoria: responsse.ID_Categoria == (null || 0) ? "%" : responsse.ID_Categoria,
    //            }
    //        }).success(function (response) {
    //            $scope.SubCategoriaList = response;
    //            $scope.New = responsse;
    //            $scope.ListarPrecio();


    //        });
    //    });
    //}





    //$scope.Edit = function () {
    //    $state.go('ProductoCreate');
    //}

    //$scope.Delete = function () {
    //    $http({
    //        method: 'Delete',
    //        url: 'api/ProductoWS',
    //        params: {
    //            ID_Producto: $('#Id').val(),
    //        }
    //    }).success(function (response) {
    //        $scope.List();
    //    });

    //}

    //if ($('#Id').val() != '0') {   //Editar

    //    getProducto($('#Id').val());

    //} else {                      //Crear

    //}

    //$scope.select = function (id) {
    //    $('#Id').val(id);


    //}
    //$scope.addPrecio = function () {

    //    if ($scope.New.ID_Producto != 0) {

    //        var modalInstance = $modal.open({
    //            templateUrl: '/Precio/Create',
    //            controller: 'PrecioController',

    //            resolve: {
    //                ID_Producto: function () {
    //                    return $scope.New.ID_Producto;
    //                },
    //                ID_Precio: function () {
    //                    return 0;
    //                },
    //                scope: function () {
    //                    return $scope;
    //                }

    //            }
    //        });

    //    } else {

    //        alert("Ingrese Producto");
    //    }


    //}


    //$scope.addMarca = function () {

    //    var modalInstance = $modal.open({
    //        templateUrl: '/Marca/MarcaAdd',
    //        controller: 'MarcaAddController',
    //        resolve: {
    //            scope: function () {
    //                return $scope;
    //            }
    //        }
    //    });
    //}

    //$scope.addCategoria = function () {

    //    var modalInstance = $modal.open({
    //        templateUrl: '/Categoria/CreateAdd',
    //        controller: 'CategoriaAddController',
    //        resolve: {
    //            scope: function () {
    //                return $scope;
    //            }
    //        }
    //    });
    //}

    //$scope.addSubCategoria = function () {
    //    if ($scope.New.ID_Categoria != null) {

    //        var modalInstance = $modal.open({
    //            templateUrl: '/SubCategoria/CreateAdd',
    //            controller: 'SubCategoriaAddController',
    //            resolve: {
    //                scope: function () {
    //                    return $scope;
    //                }
    //            }
    //        });
    //    } else {
    //        alert("Seleccione Categoria");
    //    }

    //}


}
ListaPrecioController.$inject = ['$rootScope', '$scope', '$state', '$stateParams', '$http', '$modal'];