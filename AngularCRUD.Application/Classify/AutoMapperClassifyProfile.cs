namespace AngularCRUD.Classify
{
    using AngularCRUD.Classify.DTOs.OutputModels;
    using AngularCRUD.Utilities.AutoMapper;

    using SuperPowers.Classify.Entities;

    public class AutoMapperClassifyProfile : AutoMapperBaseProfile
    {
        public AutoMapperClassifyProfile()
            : base("AutoMapperClassifyProfile")
        {

        }

        protected override void CrearMappings()
        {
            this.CreateMap<SuperPowersPerson, SuperHeroOutput>();
        }
    }
}
