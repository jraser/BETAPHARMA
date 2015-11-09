var MarcaAddController = function ($rootScope, $scope, $modalInstance, $http, scope) {

    $scope.New = {
        ID_Marca: 0,
        Descripcion: "",
        Fabricante: "",
        Estado: "",
        Codigo_Marca: "",
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
            url: 'api/MarcaWS',
            data: $scope.New,
        }).success(function (response) {
            scope.ListMarca();
            $modalInstance.dismiss('cancel');
        });


    }


  

}
MarcaAddController.$inject = ['$rootScope', '$scope', '$modalInstance', '$http', 'scope'];