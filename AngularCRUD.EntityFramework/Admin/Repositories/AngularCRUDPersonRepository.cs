namespace AngularCRUD.Classify.Repositories
{
    using Abp.EntityFramework;

    using AngularCRUD.Classify.Entities;
    using AngularCRUD.EntityFramework;
    using AngularCRUD.EntityFramework.Repositories;

    public class AngularCRUDPersonRepository : AngularCRUDRepositoryBase<SuperPowersPerson>, ISuperPowersPersonRepository
    {
        public AngularCRUDPersonRepository(IDbContextProvider<AngularCRUDDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }
    }
}
