namespace AngularCRUD.Web.Controllers
{
    using Abp.Web.Mvc.Controllers;

    /// <summary>
    /// Derive all Controllers from this class.
    /// </summary>
    public abstract class AngularCRUDControllerBase : AbpController
    {
        protected AngularCRUDControllerBase()
        {
            this.LocalizationSourceName = AngularCRUDConsts.LocalizationSourceName;
        }
    }
}