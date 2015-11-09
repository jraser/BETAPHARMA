var AlmacenController = function ($rootScope, $scope, $state, $stateParams, $http) {



    $scope.parameters = {
        ID_Sucursal: null,
    }

    $scope.New = {
        Codigo_Almacen: "",
        Descripcion_Almacen: "",
        Direccion_Almacen: "",
        ID_Sucursal: 0,
        Estado: "",
        Tipo_Almacen: ""
    }


    $scope.Create = function () {
        $('#Id').val('0');
        $state.go('AlmacenCreate');
    }

    $scope.Cancel = function () {
        $('#Id').val('0');
        $state.go('AlmacenList');
    }




    $scope.List = function () {
        console.log($scope.parameters.ID_Sucursal);
        $http({
            method: 'GET',
            url: 'api/AlmacenWS',
            params: {
                ID_Sucursal: $scope.parameters.ID_Sucursal,
            }
        }).success(function (response) {
            console.log(response);
            $scope.A2lmacenList2 = response;
        });
    }


    $scope.SaveNew = function () {
        $http({
            method: 'POST',
            url: 'api/AlmacenWS',
            data: $scope.New,
        }).success(function (response) {

            alert("Registro Correcto");
            $state.go('AlmacenList');
        });
    }

    $scope.select = function (id) {

        $('#Id').val(id);

    }

    $scope.Edit = function () {

        $state.go('AlmacenEdit');
    }

    $scope.Delete = function () {
        $http({
            method: 'Delete',
            url: 'api/AlmacenWS',
            params: {
                ID_Almacen: $('#Id').val(),
            }
        }).success(function (response) {
            $scope.List();
        });

    }



    if ($('#Id').val() != '0') {   //Editar

        return $http({
            method: 'GET',
            url: 'api/SucursalWS',
        }).success(function (response) {
            $scope.SucursalList = response;

            $http({
                method: 'GET',
                url: 'api/AlmacenWS',
                params: {
                    ID_Almacen: $('#Id').val(),
                }
            }).success(function (response) {
                $scope.New = response;

            });
        });






    } else {
        return $http({
            method: 'GET',
            url: 'api/SucursalWS',
        }).success(function (response) {
            $scope.SucursalList = response;
        });


    }







}
AlmacenController.$inject = ['$rootScope', '$scope', '$state', '$stateParams', '$http'];