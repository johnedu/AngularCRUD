namespace AngularCRUD.BaseEntity
{
    using Abp.Domain.Entities;

    public interface IMultiTenant : IEntity
    {
        int TenantId { get; set; }
    }
}