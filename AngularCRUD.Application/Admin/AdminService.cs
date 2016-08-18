namespace AngularCRUD.Admin
{
    using System.Collections.Generic;
    using System.Linq;

    using Abp.UI;

    using AngularCRUD.Admin.DTOs.InputModels;
    using AngularCRUD.Admin.DTOs.OutputModels;
    using AngularCRUD.Admin.Entities;
    using AngularCRUD.Admin.Repositories;

    using AutoMapper;

    public class AdminService : IAdminService
    {
        # region Repositorios

        private IPersonRepository _personRepository;

        # endregion

        public AdminService(IPersonRepository personRepository)
        {
            this._personRepository = personRepository;
        }

        public GetPersonOutput GetPerson(GetPersonInput personInput)
        {
            return Mapper.Map<GetPersonOutput>(_personRepository.Get(personInput.Id));
        }

        public void SavePerson(SavePersonInput personInput)
        {
            Person personExists = _personRepository.FirstOrDefault(p => p.Name.ToLower().Equals(personInput.Name.ToLower()) &&
                                                                        p.Apellido.ToLower().Equals(personInput.Apellido.ToLower()));
            if (personExists == null)
            {
                Person person = Mapper.Map<Person>(personInput);
                person.TenantId = 1;
                _personRepository.Insert(person);
            }
            else
            {
                throw new UserFriendlyException("Error trying to save a person");
            }
        }

        public void DeletePerson(DeletePersonInput personInput)
        {
            _personRepository.Delete(personInput.Id);
        }

        public void UpdatePerson(UpdatePersonInput personInput)
        {
            Person personExists = _personRepository.FirstOrDefault(p => p.Name.ToLower().Equals(personInput.Name.ToLower()) &&
                                                                        p.Apellido.ToLower().Equals(personInput.Apellido.ToLower()) &&
                                                                        p.Id != personInput.Id);
            if (personExists == null)
            {
                Person person = _personRepository.Get(personInput.Id);
                Mapper.Map(personInput, person);
                _personRepository.Update(person);
            }
            else
            {
                throw new UserFriendlyException("Error trying to update a person");
            }
        }

        public GetAllPersonsOutput GetAllPersons()
        {
            var personList = _personRepository.GetAll().OrderBy(p => p.Apellido);
            return new GetAllPersonsOutput { PersonList = Mapper.Map<List<PersonOutput>>(personList) };
        }
    }
}
