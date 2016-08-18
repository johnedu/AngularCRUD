namespace AngularCRUD.EntityFramework.Repositories
{
    using Abp.Domain.Entities;
    using Abp.EntityFramework;
    using Abp.EntityFramework.Repositories;

    using AngularCRUD.EntityFramework;

    public abstract class AngularCRUDRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<AngularCRUDDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected AngularCRUDRepositoryBase(IDbContextProvider<AngularCRUDDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class AngularCRUDRepositoryBase<TEntity> : AngularCRUDRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected AngularCRUDRepositoryBase(IDbContextProvider<AngularCRUDDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
