namespace AngularCRUD.Admin.Repositories
{
    using Abp.EntityFramework;

    using AngularCRUD.Admin.Entities;
    using AngularCRUD.EntityFramework;
    using AngularCRUD.EntityFramework.Repositories;

    public class PersonRepository : AngularCRUDRepositoryBase<Person>, IPersonRepository
    {
        public PersonRepository(IDbContextProvider<AngularCRUDDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }
    }
}
