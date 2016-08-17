using Abp.Application.Services;

namespace SuperPowers
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class AngularCRUDAppServiceBase : ApplicationService
    {
        protected AngularCRUDAppServiceBase()
        {
            LocalizationSourceName = AngularCRUDConsts.LocalizationSourceName;
        }
    }
}