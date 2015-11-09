var MarcaController = function ($rootScope, $scope, $state, $stateParams, $http) {



    $scope.parameters = {
        Descripcion: "",
        Fabricante: "",
    }

    $scope.New = {
        ID_Marca: 0,
        Descripcion: "",
        Fabricante: "",
        Estado: "",
        Codigo_Marca:"",
    }

    $scope.msj = function () {
        alert();
    }





    $scope.Create = function () {
        $('#Id').val('0');
        $state.go('MarcaCreate');
    }

    $scope.Cancel = function () {
        $('#Id').val('0');
        $state.go('MarcaList');
    }



    $scope.List = function () {
        $http({
            method: 'GET',
            url: 'api/MarcaWS',
            params: {
                Descripcion: $scope.parameters.Descripcion == (null || '') ? "%" : $scope.parameters.Descripcion,
            }
        }).success(function (response) {
            $scope.MarcaList = response;
        });
    }


    $scope.SaveNew = function () {
        $http({
            method: 'POST',
            url: 'api/MarcaWS',
            data: $scope.New,
        }).success(function (response) {

            alert("Registro Correcto");
            $('#Id').val('0');
            $state.go('MarcaList');
        });




    }


    $scope.Edit = function () {

        $state.go('MarcaEdit');
    }

    $scope.Delete = function () {
        $http({
            method: 'Delete',
            url: 'api/MarcaWS',
            params: {
                ID_Marca: $('#Id').val(),
            }
        }).success(function (response) {
            $scope.List();
        });
        
    }

    $scope.List();

    if ($('#Id').val() != '0') {   //Editar

        $http({
            method: 'GET',
            url: 'api/MarcaWS',
            params: {
                ID_Marca: $('#Id').val(),
            }
        }).success(function (response) {
            $scope.New = response;

        });



    } else {                      //Crear

    }

    $scope.select = function (id) {
        $('#Id').val(id);


    }





}
MarcaController.$inject = ['$rootScope', '$scope', '$state', '$stateParams', '$http'];