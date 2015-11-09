var AlmacenAddController = function ($rootScope, $scope, $modalInstance, $http, scope) {

    $scope.New = {
        
        Codigo_Almacen:"",
        Descripcion_Almacen: "",
        Direccion_Almacen: "",
        ID_Sucursal: scope.New.ID_Sucursal,
        Estado: "",
        Tipo_Almacen: "",
        Sucursal: $('#Sucursal option:selected').text(),
    }
 


    $scope.ok = function () {
        modeAction();

    };

    $scope.cancel = function () {

        $modalInstance.dismiss('cancel');
    };


    function modeAction() {

        $http({
            method: 'POST',
            url: 'api/AlmacenWS',
            data: $scope.New,
        }).success(function (response) {
            scope.SelectSucursal();
            $modalInstance.dismiss('cancel');
        });


    }




}
AlmacenAddController.$inject = ['$rootScope', '$scope', '$modalInstance', '$http', 'scope'];