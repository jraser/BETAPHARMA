var PrecioAddController = function ($rootScope, $scope, $modalInstance, $http, scope,Id) {

    $scope.Item = {
        ID_Producto: Id,
        ID_Precio: 0,
        PC: 0
    }

    $scope.List = function () {

        $http({
            method: 'GET',
            url: 'api/PrecioWS',
            params: {
                ID_Producto: Id,
            }
        }).success(function (response) {
            $scope.PrecioList = response;
        });

    }


    $scope.Select = function (item) {
        $.each($scope.PrecioList, function (index, value) {
            if (value.ID_Precio != item.ID_Precio) {
                value.checked = false;
            } else {
                value.checked = true;
                $scope.Item.ID_Producto= Id;
                $scope.Item.ID_Precio= item.ID_Precio;
                $scope.Item.PC= item.PC;
               
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
        if ($scope.Item.ID_Precio!=0) {

            scope.getproducto($scope.Item);
            $modalInstance.dismiss('cancel');


        } else {

            alert("No selecciono Item");
        }


    }

    $scope.List();


}
PrecioAddController.$inject = ['$rootScope', '$scope', '$modalInstance', '$http', 'scope','Id'];

