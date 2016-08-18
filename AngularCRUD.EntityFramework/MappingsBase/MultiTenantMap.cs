namespace AngularCRUD.MappingsBase
{
    using System.Data.Entity.ModelConfiguration;

    using AngularCRUD.BaseEntity;

    public class MultiTenantMap<TMultiTenantEntidad> : EntityTypeConfiguration<TMultiTenantEntidad>
        where TMultiTenantEntidad : class, IMultiTenant
    {
        public MultiTenantMap()
            : base()
        {
            //Llave Primaria
            this.HasKey(mt => mt.Id);

            //Propiedad de TenantId
            this.Property(mt => mt.TenantId).IsRequired();
        }

    }
}
