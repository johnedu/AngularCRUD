using Abp.Web.Mvc.Views;

namespace SuperPowers.Web.Views
{
    public abstract class AngularCRUDWebViewPageBase : AngularCRUDWebViewPageBase<dynamic>
    {

    }

    public abstract class AngularCRUDWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected AngularCRUDWebViewPageBase()
        {
            LocalizationSourceName = AngularCRUDConsts.LocalizationSourceName;
        }
    }
}