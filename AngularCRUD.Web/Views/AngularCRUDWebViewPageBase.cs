namespace AngularCRUD.Web.Views
{
    using Abp.Web.Mvc.Views;

    public abstract class AngularCRUDWebViewPageBase : AngularCRUDWebViewPageBase<dynamic>
    {

    }

    public abstract class AngularCRUDWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected AngularCRUDWebViewPageBase()
        {
            this.LocalizationSourceName = AngularCRUDConsts.LocalizationSourceName;
        }
    }
}