using Abp.Web.Mvc.Views;

namespace SuperPowers.Web.Views
{
    public abstract class AngularCRUDWebViewPageBase : SuperPowersWebViewPageBase<dynamic>
    {

    }

    public abstract class SuperPowersWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected SuperPowersWebViewPageBase()
        {
            LocalizationSourceName = AngularCRUDConsts.LocalizationSourceName;
        }
    }
}