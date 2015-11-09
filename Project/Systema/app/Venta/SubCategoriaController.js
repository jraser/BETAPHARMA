var SubCategoriaController = function ($rootScope, $scope, $state, $stateParams, $http) {



    $scope.parameters = {
        ID_Categoria: null,
    }

    $scope.New = {
        ID_Categoria: 0,
        Nombre: "",
        Estado: ""
    }


    $scope.Create = function () {
        $('#Id').val('0');
        $state.go('SubCategoriaCreate');
    }

    $scope.Cancel = function () {
        $('#Id').val('0');
        $state.go('SubCategoriaList');
    }


  

    $scope.List = function () {
        console.log($scope.parameters.ID_Categoria);
        $http({
            method: 'GET',
            url: 'api/SubCategoriaWS',
            params: {
                ID_Categoria: $scope.parameters.ID_Categoria == (null||0) ? 0 : $scope.parameters.ID_Categoria,
            }
        }).success(function (response) {
            console.log(response);
            $scope.SubCategoriaList = response;
        });
    }

  
    $scope.SaveNew = function () {
        $http({
            method: 'POST',
            url: 'api/SubCategoriaWS',
            data: $scope.New,
        }).success(function (response) {

            alert("Registro Correcto");
            $state.go('SubCategoriaList');
        });




    }

    $scope.select = function (id) {
        
        $('#Id').val(id);

    }

    $scope.Edit = function () {

        $state.go('SubCategoriaEdit');
    }

    $scope.Delete = function () {
        $http({
            method: 'Delete',
            url: 'api/SubCategoriaWS',
            params: {
                ID_SubCategoria: $('#Id').val(),
            }
        }).success(function (response) {
            $scope.List();
        });

    }

    

    if ($('#Id').val() != '0') {   //Editar
       
        return $http({
            method: 'GET',
            url: 'api/CategoriaWS',
        }).success(function (response) {
            $scope.CategoriaList = response;

            $http({
                method: 'GET',
                url: 'api/SubCategoriaWS',
                params: {
                    ID_SubCategoria: $('#Id').val(),
                }
            }).success(function (response) {
                $scope.New = response;

            });
        });


      



    } else {                    
        return $http({
            method: 'GET',
            url: 'api/CategoriaWS',
        }).success(function (response) {
            $scope.CategoriaList = response;
        });

       
    }







}
SubCategoriaController.$inject = ['$rootScope', '$scope', '$state', '$stateParams', '$http'];