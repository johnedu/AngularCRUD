namespace AngularCRUD
{
    using Abp.Application.Services;

    using SuperPowers;

    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class AngularCRUDAppServiceBase : ApplicationService
    {
        protected AngularCRUDAppServiceBase()
        {
            this.LocalizationSourceName = AngularCRUDConsts.LocalizationSourceName;
        }
    }
}