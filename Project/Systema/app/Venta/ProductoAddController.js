var ProductoAddController = function ($rootScope, $scope, $modalInstance, $http, scope) {

    $scope.parameters = {
        Descripcion: "",
    }

    $scope.List = function () {


        $http({
            method: 'GET',
            url: 'api/ProductoWS',
            params: {
                Descripcion: $scope.parameters.Descripcion == (null || '') ? "%" : $scope.parameters.Descripcion,
                ID_Socio:scope.New.ID_Socio
            }
        }).success(function (response) {
            $scope.ProductoList = response;

            $.each($scope.ProductoList, function (index, value) {
                value.checked = false;
                
            });

        });



    }

    $scope.ok = function () {
        var lista = [];
        $.each($scope.ProductoList, function (index, value) {
            if (value.checked == true) {
                value.checked = false;
                lista.push(value);
            }
        });
        modeAction(lista);

    };

    $scope.cancel = function () {

        $modalInstance.dismiss('cancel');
    };


    function modeAction(lista) {
        if (lista.length > 0) {
            scope.getdetalle(lista);
            $modalInstance.dismiss('cancel');
        } else {

            alert("No selecciono Item");
        }
       
    }

    $scope.List();


}
ProductoAddController.$inject = ['$rootScope', '$scope', '$modalInstance', '$http', 'scope'];

