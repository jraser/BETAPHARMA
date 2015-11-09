var GrupoController = function ($rootScope, $scope, $state, $stateParams, $http) {

    $scope.parameters = {
        Nombre: "",
        TipoEstado: "",
    }
    $scope.New = {
        ID_Grupo: 0,
        Nombre: "",
        Estado: ""
    }

    $scope.msj = function () {
        alert();
    }





    $scope.Create = function () {
        $('#Id').val('0');
        $state.go('GrupoCreate');
    }

    $scope.Cancel = function () {
        $('#Id').val('0');
        $state.go('GrupoList');
    }



    $scope.List = function () {
        $http({
            method: 'GET',
            url: 'api/GrupoWS',
            params: {
                Nombre: $scope.parameters.Nombre == (null || '') ? "%" : $scope.parameters.Nombre,
                TipoEstado: $scope.parameters.TipoEstado == (null || '') ? "%" : $scope.parameters.TipoEstado,
            }
        }).success(function (response) {
            $scope.GrupoList = response;
        });
    }


    $scope.SaveNew = function () {
        $http({
            method: 'POST',
            url: 'api/GrupoWS',
            data: $scope.New,
        }).success(function (response) {
            var Id = response;
            
            if (Id != 0) {
                for (var i = 0; i < $scope.DescuentoList.length; i++) {
                    var item = $scope.DescuentoList[i];
                    item.ID_Grupo = Id;
                    if (item.checked) {
                        $http({
                            method: 'POST',
                            url: 'api/DescuentoGrupoWS',
                            data: item,
                        }).success(function (response) {

                        });
                    }
                }
                alert("Registro Correcto");
                $state.go('GrupoList');
            }
        });




    }

    $scope.Delete = function () {

        $http({
            method: 'Delete',
            url: 'api/GrupoWS',
            params: {
                ID_Grupo: $('#Id').val(),
            }
        }).success(function (response) {
            $scope.List();

            alert("Registro Eliminado");

        }).catch(function (err) {
            alert("Este grupo contiene Registros", err);
            throw err;
        }).finally(function () {
            alert("");
        });

    }

    function getDescuentos(Id) {
        $http({
            method: 'GET',
            url: 'api/DescuentoProductoWS',
            params: {
                ID_Grupo: Id,
                Mode:'1'
            }
        }).success(function (response) {
            $scope.DescuentoList = response;

            for (var i = 0; i < $scope.DescuentoList.length; i++) {
                var item = $scope.DescuentoList[i];
                if (item.ID_Grupo != 0) {
                    item.checked = true;
                } else {
                    item.checked = false;
                }
            }

        });

    }
    $scope.Edit = function () {
       
        $state.go('GrupoEdit');
    }






    $scope.EstadoModificado = function () {
        $http({
            method: 'POST',
            url: 'api/GrupoWS',
            params: {
                ID_Grupo: $('#Id').val(),
            }
        }).success(function (response) {
            $scope.List();
        });
        alert("Estado Modificado a Desactivado");
    }


    $scope.PUT = function () {
        $http({
            method: 'PUT',
            url: 'api/GrupoWS',
            params: {
                ID_Grupo: $('#Id').val(),
            }
        }).success(function (response) {
            $scope.List();
        });
        alert("Estado Modificado a Aceptado")
    }


    $scope.List();

    if ($('#Id').val() != '0') {   //Editar

        $http({
            method: 'GET',
            url: 'api/GruposWS',
            params: {
                ID_Grupo: $('#Id').val(),
            }
        }).success(function (response) {
            $scope.New = response;
            getDescuentos($('#Id').val());
        });



    } else {                      //Crear
        getDescuentos(0);
    }

    $scope.select = function (id) {
        $('#Id').val(id);


    }



}
GrupoController.$inject = ['$rootScope', '$scope', '$state', '$stateParams', '$http'];