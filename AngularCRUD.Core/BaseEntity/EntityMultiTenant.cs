namespace AngularCRUD.BaseEntity
{
    using Abp.Domain.Entities;

    public abstract class EntityMultiTenant : Entity, IMultiTenant, IMustHaveTenant
    {
        public int TenantId { get; set; }
    }

}