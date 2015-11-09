var DescuentoAddController = function ($rootScope, $scope, $modalInstance, $http, scope, Id) {

    $scope.Item = {
        ID_Producto: Id,
        ID_Descuento: 0,
        PorcDscto: 0
    }
   
    $scope.List = function () {

        $http({
            method: 'GET',
            url: 'api/DescuentoProductoWS',
            params: {
                ID_Grupo: scope.New.ID_Grupo,
                Mode: '2'
            }
        }).success(function (response) {
            $scope.DescuentoList = response;
        });
    }


    $scope.Select = function (item) {
        $.each($scope.DescuentoList, function (index, value) {
            if (value.ID_Descuento != item.ID_Descuento) {
                value.checked = false;
            } else {
                value.checked = true;
                $scope.Item.ID_Producto = Id;
                $scope.Item.ID_Descuento = item.ID_Descuento;
                $scope.Item.PorcDscto = item.PorcDscto;

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
        if ($scope.Item.ID_Descuento != 0) {

            scope.getdescuento($scope.Item);
            $modalInstance.dismiss('cancel');


        } else {

            alert("No selecciono Item");
        }


    }

    $scope.List();


}
DescuentoAddController.$inject = ['$rootScope', '$scope', '$modalInstance', '$http', 'scope', 'Id'];



