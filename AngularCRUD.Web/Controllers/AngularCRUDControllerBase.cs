using Abp.Web.Mvc.Controllers;

namespace SuperPowers.Web.Controllers
{
    /// <summary>
    /// Derive all Controllers from this class.
    /// </summary>
    public abstract class AngularCRUDControllerBase : AbpController
    {
        protected AngularCRUDControllerBase()
        {
            LocalizationSourceName = AngularCRUDConsts.LocalizationSourceName;
        }
    }
}