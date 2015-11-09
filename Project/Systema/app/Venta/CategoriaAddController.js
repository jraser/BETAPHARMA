var CategoriaAddController = function ($rootScope, $scope, $modalInstance, $http, scope) {

    $scope.New = {
        ID_Categoria: 0,
        Nombre: "",
        Estado: ""
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
            url: 'api/CategoriaWS',
            data: $scope.New,
        }).success(function (response) {
            scope.ListCategoria();
            $modalInstance.dismiss('cancel');
        });


    }




}
CategoriaAddController.$inject = ['$rootScope', '$scope', '$modalInstance', '$http', 'scope'];