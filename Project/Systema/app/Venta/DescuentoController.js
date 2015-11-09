var DescuentoController = function ($rootScope, $scope, $state, $stateParams, $http) {


    $scope.parameters = {
        Nombre: "",
    }

    $scope.New = {
        ID_Descuento: 0,
        Nombre: "",
        Descripcion: "",
        PorcDscto: "",

    }

 




    $scope.Create = function () {
        $('#Id').val('0');
        $state.go('DescuentoCreate');
    }

    $scope.Cancel = function () {
        $('#Id').val('0');
        $state.go('DescuentoList');
    }



    $scope.List = function () {
        $http({
            method: 'GET',
            url: 'api/DescuentosProductoWS',
            params: {
                Nombre: $scope.parameters.Nombre == (null || '') ? "%" : $scope.parameters.Nombre,
            }
        }).success(function (response) {
            $scope.DescuentoList = response;
        });
    }


    $scope.SaveNew = function () {
        $http({
            method: 'POST',
            url: 'api/DescuentoProductoWS',
            data: $scope.New,
        }).success(function (response) {
            alert("Registro Correcto");
            $state.go('DescuentoList');
        });




    }

   
    $scope.Edit = function () {
        
        $state.go('DescuentoEdit');
    }
    $scope.Delete = function () {
        $http({
            method: 'Delete',
            url: 'api/DescuentoProductoWS',
            params: {
                ID_Descuento: $('#Id').val(),
            }
        }).success(function (response) {
            $scope.List();
        });
        
    }

    $scope.List();

    if ($('#Id').val() != '0') {   //Editar

        $http({
            method: 'GET',
            url: 'api/DescuentoProductoWS',
            params: {
                ID_Descuento: $('#Id').val(),
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
DescuentoController.$inject = ['$rootScope', '$scope', '$state', '$stateParams', '$http'];