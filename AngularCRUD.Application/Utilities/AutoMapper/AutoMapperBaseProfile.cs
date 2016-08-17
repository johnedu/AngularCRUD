namespace AngularCRUD.Utilities.AutoMapper
{
    using global::AutoMapper;

    public abstract class AutoMapperBaseProfile : Profile
    {
        private readonly string _nombreProfile;

        protected AutoMapperBaseProfile(string nombreProfile)
        {
            this._nombreProfile = nombreProfile;
        }

        public override string ProfileName
        {
            get
            {
                return this._nombreProfile;
            }
        }

        protected override void Configure()
        {
            this.CrearMappings();
        }

        protected abstract void CrearMappings();
    }
}
