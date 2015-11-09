var SubCategoriaAddController = function ($rootScope, $scope, $modalInstance, $http, scope) {

    $scope.New = {
        ID_Categoria: scope.New.ID_Categoria,
        Nombre: "",
        Estado: "",
        Categoria: $('#Categoria option:selected').text(),
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
            url: 'api/SubCategoriaWS',
            data: $scope.New,
        }).success(function (response) {
            scope.SelectCategoria();
            $modalInstance.dismiss('cancel');
        });


    }




}
SubCategoriaAddController.$inject = ['$rootScope', '$scope', '$modalInstance', '$http', 'scope'];