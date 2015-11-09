var SocioNegocioController = function ($rootScope, $scope, $state, $stateParams, $http) {

    $scope.parameters = {
        Nombres: "",
        Nro_Documento: "",
        TipoSocio:"",
      

    }

    $scope.New = {
        ID_Socio: 0,
        Tipo_Socio: "",
        Regimen_Socio: "",
        Tipo_Documento: "",
        Num_Documento: "",
        Nombres_Socio: "",
        NombreComercial_Socio: "",
        Telefono: "",
        Origen_Socio: "",
        Direccion_Socio: "",
        Estado: "",



    }


    $scope.New2 = {
        ID_Direccion: 0,
        Direccion: '',
        Referencia_Domicilio: '',
        ID_Ubigeo: 0,
        ID_Socio: 0,
        Tipo:'',
    }


    $scope.msj = function () {
        alert();
    }

    $scope.Create = function () {

        $('#Id').val('0');

        $state.go('SocioNegocioCreate');

    }

    $scope.Cancel = function () {

        $('#Id').val('0');
        $state.go('SocioNegocioList');

    }

    $scope.List = function () {
        $http({
            method: 'GET',
            url: 'api/SocioNegocioWS',
            params: {

                Nombres: $scope.parameters.Nombres == (null || '') ? "%" : $scope.parameters.Nombres,
                Nro_Documento: $scope.parameters.Nro_Documento == (null || '') ? "%" : $scope.parameters.Nro_Documento,
                TipoSocio: $scope.parameters.TipoSocio == (null || '') ? "%" : $scope.parameters.TipoSocio,
                
            }

        }).success(function (response) {
            $scope.SocioNegocioList = response;

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

    $scope.SaveNew = function () {
        $http({
            method: 'POST',
            url: 'api/SocioNegocioWS',
            data: $scope.New,
        }).success(function (response) {
            $scope.New.ID_Socio = response;
            alert("Registro Correcto");
            $state.go('SocioNegocioCreate');


        });

    }



    $scope.Deletes = function () {
        $http({
            method: 'Delete',
            url: 'api/SocioNegocioWS',
            params: {
                ID_Socio: $('#Id').val(),
            }
        }).success(function (response) {
            $scope.List();
        });

    }


    $scope.SaveDNew = function () {
        $scope.New2.ID_Socio = $scope.New.ID_Socio;

        $http({
            method: 'POST',
            url: 'api/DireccionWS',
            data: $scope.New2,
        }).success(function (response) {
            $scope.New2.Direccion = '';
            $scope.DList();
        });
    }

    $scope.select2 = function (Id) {
        $scope.Id = Id;
    }

    $scope.Delete = function () {
        $http({
            method: 'Delete',
            url: 'api/DireccionWS',
            params: {
                ID_Direccion: $scope.Id,
            }
        }).success(function (response) {
            $scope.New2.Direccion = '';
            $scope.DList();
        });

    }

    $scope.Edit = function () {

        $state.go('SocioNegocioCreate');
    }


    if ($('#Id').val() != '0') {   //Editar

        $http({
            method: 'GET',
            url: 'api/SocioNegocioWS',
            params: {

                ID_Socio: $('#Id').val(),

            }
        }).success(function (response) {
            $scope.New = response;
            $scope.DList();

        });
    } else {                      //Crear

    }

    $scope.select = function (id) {
        $('#Id').val(id);
    }



    $http({
        method: 'GET',
        url: 'api/GrupoWS',
        params: {
            Nombre: "%",
        }
    }).success(function (response) {
        $scope.GrupoList = response;
    });

     $scope.List();

}
SocioNegocioController.$inject = ['$rootScope', '$scope', '$state', '$stateParams', '$http'];

