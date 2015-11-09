var StockAddController = function ($rootScope, $scope, $modalInstance, $http, scope) {

    $scope.parameters = {
        Descripcion: "",
    }

    $scope.List = function () {


        $http({
            method: 'GET',
            url: 'api/StockWS',
            params: {
                Descripcion: $scope.parameters.Descripcion == (null || '') ? "%" : $scope.parameters.Descripcion,
            }
        }).success(function (response) {
            $scope.StockAdd = response;

            $.each($scope.StockAdd, function (index, value) {
                value.checked = false;

            });

        });



    }

    $scope.ok = function () {
        var lista = [];
        $.each($scope.StockAdd, function (index, value) {
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
StockAddController.$inject = ['$rootScope', '$scope', '$modalInstance', '$http', 'scope'];

