
var SocioNegocioAddController = function ($rootScope, $scope, $modalInstance, $http, scope) {

    $scope.Item = {
        ID_Socio: 0,
        Nro_Documento: '',
        Nombres: ''
    }

    $scope.parameters = {
        Nombres: "",
        Nro_Documento: "",

    }
    $scope.List = function () {

        $http({
            method: 'GET',
            url: 'api/SocioNegocioWS',
            params: {

                Nombres: $scope.parameters.Nombres == (null || '') ? "%" : $scope.parameters.Nombres,
                Nro_Documento: $scope.parameters.Nro_Documento == (null || '') ? "%" : $scope.parameters.Nro_Documento,
                TipoSocio: 'P'
            }
        }).success(function (response) {
            $scope.SocioNegocioList = response;

        });

    }


    $scope.Select = function (item) {
        $.each($scope.SocioNegocioList, function (index, value) {
            if (value.ID_Socio != item.ID_Socio) {
                value.checked = false;
            } else {
                value.checked = true;
                $scope.Item.ID_Socio = item.ID_Socio;
                $scope.Item.Nro_Documento = item.Nro_Documento;
                $scope.Item.Nombres = item.Nombres;
                $scope.Item.ID_Grupo = item.ID_Grupo;


            }
        });

    }




    $scope.ok = function () {

        modeAction();

    };

    $scope.cancel = function () {

        $modalInstance.dismiss('cancel');
    };


    function modeAction() {
        if ($scope.Item.ID_Socio != 0) {

            scope.getsocio($scope.Item);
            $modalInstance.dismiss('cancel');


        } else {

            alert("No selecciono Item");
        }


    }

    $scope.List();


}
SocioNegocioAddController.$inject = ['$rootScope', '$scope', '$modalInstance', '$http', 'scope'];




