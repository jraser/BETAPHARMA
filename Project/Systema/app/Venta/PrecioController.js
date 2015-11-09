
var PrecioController = function ($rootScope, $scope, $modalInstance, $http, ID_Producto, ID_Precio, scope) {



    $scope.New = {
        ID_Precio: ID_Precio,
        ID_Producto: ID_Producto,
        PV: '',
        PC: '',
        ID_Socio: '',
        Nombres: ''
    }


    $scope.List = function () {

        $http({
            method: 'GET',
            url: 'api/SocioNegocioWS',
            params: {

                TipoSocio: 'P',
                Nombres: ''

            }
        }).success(function (response) {
            $scope.SocioList = response;

        });

    }



    $scope.ok = function () {
        modeAction();

    };

    $scope.cancel = function () {

        $modalInstance.dismiss('cancel');
    };


    function modeAction() {

        $http({
            method: 'Post',
            url: 'api/PrecioWS',
            data: $scope.New,
        }).success(function (response) {
            scope.ListarPrecio();
            $modalInstance.dismiss('cancel');
        });


    }


    if (ID_Precio != 0) {
        $http({
            method: 'Get',
            url: 'api/PrecioWS',
            params: {
                ID_Precio: ID_Precio,
                cod: 0
            }
        }).success(function (responsse) {
            $scope.New = responsse;
        });

    }

    $scope.List();



}
PrecioController.$inject = ['$rootScope', '$scope', '$modalInstance', '$http', 'ID_Producto', 'ID_Precio', 'scope'];