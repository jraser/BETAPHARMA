var CategoriaController = function ($rootScope, $scope, $state, $stateParams, $http) {



    $scope.parameters = {
        Nombre: "",
    }

    $scope.New = {
        ID_Categoria: 0,
        Nombre: "",
        Estado: ""
    }

    $scope.msj = function () {
        alert();
    }



    $scope.Create = function () {
        $('#Id').val('0');
        $state.go('CategoriaCreate');
    }

    $scope.Cancel = function () {
        $('#Id').val('0');
        $state.go('CategoriaList');
    }



    $scope.List = function () {
        $http({
            method: 'GET',
            url: 'api/CategoriaWS',
            params: {
                Nombre: $scope.parameters.Nombre == (null || '') ? "%" : $scope.parameters.Nombre,
            }
        }).success(function (response) {
            $scope.CategoriaList = response;
        });
    }


    $scope.SaveNew = function () {
        $http({
            method: 'POST',
            url: 'api/CategoriaWS',
            data: $scope.New,
        }).success(function (response) {
            
            alert("Registro Correcto");
            $state.go('CategoriaList');
        });




    }

  
    $scope.Edit = function () {

        $state.go('CategoriaEdit');
    }

    $scope.Delete = function () {
        $http({
            method: 'Delete',
            url: 'api/CategoriaWS',
            params: {
                ID_Categoria: $('#Id').val(),
            }
        }).success(function (response) {
            $scope.List();
        });

    }


    $scope.List();

    if ($('#Id').val() != '0') {   //Editar

        $http({
            method: 'GET',
            url: 'api/CategoriaWS',
            params: {
                ID_Categoria: $('#Id').val(),
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
CategoriaController.$inject = ['$rootScope', '$scope', '$state', '$stateParams', '$http'];