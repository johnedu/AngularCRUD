(function () {
    //Nombre del controlador   
    var controllerId = 'app.views.admin.persons';

    /*****************************************************************
    * 
    * CONTROLADOR
    * 
    *****************************************************************/

    angular.module('app').controller(controllerId, ['$scope', '$modal', 'abp.services.app.admin',
       function ($scope, $modal, adminService) {
           var vm = this;

           vm.personList = [];

           vm.person = {
               id: '',
               name: '',
               apellido: '',
               edad: ''
           };

           vm.loadPersons = function () {
               adminService.getAllPersons().success(function (data) {
                   vm.personList = data.personList;
               });
           }

           vm.loadPersons();

           /************************************************************************
            * Llamado para abrir Modal para Nueva Persona
            ************************************************************************/
           vm.abrirModalNueva= function () {
               var modalInstance = $modal.open({
                   templateUrl: '/App/Main/views/admin/persons/partials/modalNewPerson.cshtml',
                   controller: 'modalNewPersonController',
                   size: 'md'
               });

               modalInstance.result.then(function () {
                   vm.loadPersons();
                   abp.notify.success('Se guardó correctamente la persona', 'Información');
               }, function () {
                   vm.resultado = 'Ocurrió un problema al guardar la persona';
               });
           }

           /************************************************************************
           * Llamado para abrir Modal para Editar una Persona
           ************************************************************************/
           vm.abrirModalEditar = function (personId, personName) {
               var modalInstance = $modal.open({
                   templateUrl: '/App/Main/views/admin/persons/partials/modalEditPerson.cshtml',
                   controller: 'modalEditPersonController',
                   size: 'md',
                   resolve: {
                       personToEdit: function () {
                           return personId;
                       },
                       personName: function () {
                           return personName;
                       }
                   }
               });

               modalInstance.result.then(function () {
                   abp.notify.success('Se actualizó correctamente la persona', 'Información');
                   vm.loadPersons();
               }, function () {
                   vm.resultado = 'Ocurrió un problema al actualizar la persona';
               });
           }

           /************************************************************************
           * Llamado para abrir Modal para Eliminar una Persona
           ************************************************************************/
           vm.abrirModalEliminar = function (personId) {
                var modalInstance = $modal.open({
                    templateUrl: '/App/Main/views/admin/persons/partials/modalDeletePersons.cshtml',
                    controller: 'modalDeletePersonController',
                    size: 'md',
                    resolve: {
                        personToDelete: function () {
                            return personId;
                        }
                    }
                });

                modalInstance.result.then(function () {
                    vm.loadPersons();
                    abp.notify.success('Se eliminó correctamente la persona', 'Información');
                }, function () {
                    vm.resultado = 'Ocurrió un problema al actualizar la persona';
                });
           }
       }]);
})();