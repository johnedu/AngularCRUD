namespace AngularCRUD.Admin
{
    using AngularCRUD.Admin.DTOs.InputModels;
    using AngularCRUD.Admin.DTOs.OutputModels;
    using AngularCRUD.Admin.Entities;
    using AngularCRUD.Utilities.AutoMapper;

    public class AutoMapperAdminProfile : AutoMapperBaseProfile
    {
        public AutoMapperAdminProfile()
            : base("AutoMapperAdminProfile")
        {

        }

        protected override void CrearMappings()
        {
            CreateMap<SavePersonInput, Person>();
            CreateMap<UpdatePersonInput, Person>();
            CreateMap<Person, GetPersonOutput>();
            CreateMap<Person, PersonOutput>();
        }
    }
}
