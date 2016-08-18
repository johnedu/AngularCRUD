(function () {
    angular.module('app').controller('modalNewPersonController', ['$scope', '$modalInstance', 'abp.services.app.admin',
        function ($scope, $modalInstance, adminService) {

            $scope.person = {
                name: '',
                apellido: '',
                edad: 0
            };

            $scope.okModal = function () {
                adminService.savePerson($scope.person)
                    .success(function () {
                        $modalInstance.close($scope.person.name);
                    }).error(function (error) {
                        $scope.mensajeError = error.message;
                    });
            }

            $scope.cancelModal = function () {
                $modalInstance.dismiss('cancel');
            }
        }]);
})();