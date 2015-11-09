var SucursalController = function ($rootScope, $scope, $state, $stateParams, $http) {



    $scope.parameters = {
        Nombre: "",
    }

    $scope.New = {
        ID_Sucursal: 0,
        Codigo_Sucursal: "",
        Descripcion_Sucursal: '',
        Direccion: '',
        Estado: ""
    }

    $scope.msj = function () {
        alert();
    }


    $scope.Create = function () {
        $('#Id').val('0');
        $state.go('SucursalCreate');
    }

    $scope.Cancel = function () {
        $('#Id').val('0');
        $state.go('SucursalList');
    }



    $scope.List = function () {
        $http({
            method: 'GET',
            url: 'api/SucursalWS',
           
        }).success(function (response) {
            $scope.SucursalList = response;
        });
    }



    $scope.SaveNew = function () {
        $http({
            method: 'POST',
            url: 'api/SucursalWS',
            data: $scope.New,
        }).success(function (response) {

        
            alert("Registro Correcto");
            $state.go('SucursalList');
        });
    }


    $scope.DeleteS = function () {
        $http({
            method: 'Delete',
            url: 'api/SucursalWS',
            params: {
                ID_Sucursal: $('#Id').val(),
            }
        }).success(function (response) {
            $scope.List();
        });

    }


    $scope.SaveANew = function () {
        $scope.New2.ID_Sucursal = $scope.New.ID_Sucursal;

        $http({
            method: 'POST',
            url: 'api/AlmacenWS',
            data: $scope.New2,
        }).success(function (response) {
            $scope.New2.Descripcion_Almacen = '';
            $scope.AList();
        });
    }

    $scope.select2 = function (Id) {
        $scope.Id = Id;
    }
    
    $scope.Delete = function () {
        $http({
            method: 'Delete',
            url: 'api/AlmacenWS',
            params: {
                ID_Almacen: $scope.Id,
            }
        }).success(function (response) {
            $scope.New2.Descripcion_Almacen = '';
            $scope.AList();
        });

    }


    $scope.Edit = function () {
     
        $state.go('SucursalEdit');
    }

    $scope.List();

    if ($('#Id').val() != '0') {   //Editar

        $http({
            method: 'GET',
            url: 'api/SucursalWS',
            params: {
                ID_Sucursal: $('#Id').val(),
            }
        }).success(function (response) {
            $scope.New = response;
            $scope.AList();
        });

    } else {                      //Crear

    }

    $scope.select = function (id) {
        $('#Id').val(id);


    }


}
SucursalController.$inject = ['$rootScope', '$scope', '$state', '$stateParams', '$http'];