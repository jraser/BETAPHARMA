var CuentaController = function ($rootScope, $scope, $state, $stateParams, $http) {


   

    $scope.parameters = {
        Codigo: "",
    }

    $scope.New = {
        ID_Grupo: 0,
        Nombre: "",
        Estado: ""
    }




    $scope.List = function () {

         $http({
            method: 'GET',
            url: 'api/CuentaWS',
            params: {
                Codigo: $scope.parameters.Codigo == (null || '') ? "%" : $scope.parameters.Codigo,
            }
        }).success(function (response) {
            $scope.CuentaList = response;


        });

    }

    $scope.Create = function () {

        $state.go('GrupoCreate');

    }

    $scope.Cancel = function () {
        $state.go('CuentaList');

    }

    $scope.ItemClick = function (item) {
     
        $scope.Id = item.ID_PlanCuenta;
        $scope.codigo = item.CodigoCuenta;
        $scope.Nivel = item.Nivel;
        $scope.Origen = item.Origen;

        $scope.new();
    }
   


    $scope.SaveNew = function () {
        if (true) {
           

        }


    }

    function getniveles(nivel) {
        var data = [];
        for (var i = 1; i <= 5; i++) {
            if (i > nivel) {
                data.push({ Codigo: i, ValorCadena: 'Nivel ' + i });
            }
        }
        return data;
    }

    $scope.new=function(){
       
        if ($scope.Nivel < 5) {
            $scope.Cuenta = {
                CodigoCuentaPadre: $scope.codigo,
                CodigoCuenta: '',
                DescripcionCuenta: '',
                Nivel: null
            }
            $scope.niveles = getniveles($scope.Nivel);


        } else {

            alert("Nivel max. 5");
        }
    }

    $scope.delete = function () {
        if ($scope.Origen == 2) {

             $http({
                method: 'DELETE',
                url: 'api/CuentaWS',
                params: {
                    Id: $scope.Id,
                }
            }).success(function (response) {
                alert("Se elimino el registro");
                $scope.List();
            });

           

        } else {

            alert("Este nivel no se puede eliminar");
        }

     
    }

    $scope.ok = function () {

        $http({
            method: 'POST',
            url: 'api/CuentaWS',
            data: $scope.Cuenta,
        }).success(function (response) {
            $scope.List();
           
        });

    };
 
    $scope.cancel = function () {
        $scope.parameters.Codigo = '';
        $scope.List();
        $scope.niveles = null;

        $scope.Cuenta.CodigoCuentaPadre ='';
        $scope.Cuenta.CodigoCuenta ='';
        $scope.Cuenta.DescripcionCuenta ='';
        $scope.Cuenta.Nivel = null;
        $scope.Nivel='';

    };


}
CuentaController.$inject = ['$rootScope', '$scope', '$state', '$stateParams', '$http'];