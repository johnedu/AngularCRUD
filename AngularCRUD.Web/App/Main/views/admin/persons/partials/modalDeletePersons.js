(function () {
    angular.module('app').controller('modalDeletePersonController', ['$scope', '$modalInstance', 'personToDelete', 'abp.services.app.admin',
        function ($scope, $modalInstance, personToDelete, adminService) {
            $scope.person = '';

            adminService.getPerson({ id: personToDelete })
                .success(function (data) {
                    $scope.person = data;
                });

            $scope.okModal = function () {
                adminService.deletePerson({ id: personToDelete })
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

