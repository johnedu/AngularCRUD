(function () {
    angular.module('app').controller('modalEditPersonController', ['$scope', '$modalInstance', 'personToEdit', 'personName', 'abp.services.app.admin',
        function ($scope, $modalInstance, personToEdit, personName, adminService) {

            $scope.personName = personName;
            $scope.person = '';

            adminService.getPerson({ id: personToEdit })
                .success(function (data) {
                    $scope.person = data;
                });

            $scope.okModal = function () {
                adminService.updatePerson($scope.person)
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