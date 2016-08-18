namespace AngularCRUD.Admin
{
    using Abp.Application.Services;

    using AngularCRUD.Admin.DTOs.InputModels;
    using AngularCRUD.Admin.DTOs.OutputModels;

    public interface IAdminService : IApplicationService
    {
        GetPersonOutput GetPerson(GetPersonInput personInput);

        void SavePerson(SavePersonInput personInput);

        void DeletePerson(DeletePersonInput personInput);

        void UpdatePerson(UpdatePersonInput personInput);

        GetAllPersonsOutput GetAllPersons();
    }
}
