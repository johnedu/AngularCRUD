namespace AngularCRUD.Web
{
    using System.Reflection;
    using System.Web;
    using System.Web.Mvc;
    using System.Web.Optimization;
    using System.Web.Routing;

    using Abp.Localization;
    using Abp.Localization.Sources.Xml;
    using Abp.Modules;

    using AngularCRUD;

    [DependsOn(typeof(AngularCRUDDataModule), typeof(AngularCRUDApplicationModule), typeof(AngularCRUDWebApiModule))]
    public class AngularCRUDWebModule : AbpModule
    {
        public override void PreInitialize()
        {
            //Add/remove languages for your application
            this.Configuration.Localization.Languages.Add(new LanguageInfo("en", "English", "famfamfam-flag-england", true));
            this.Configuration.Localization.Languages.Add(new LanguageInfo("tr", "Türkçe", "famfamfam-flag-tr"));

            //Add/remove localization sources here
            this.Configuration.Localization.Sources.Add(
                new XmlLocalizationSource(
                    AngularCRUDConsts.LocalizationSourceName,
                    HttpContext.Current.Server.MapPath("~/Localization/AngularCRUD")));

            //Configure navigation/menu
            this.Configuration.Navigation.Providers.Add<AngularCRUDNavigationProvider>();
        }

        public override void Initialize()
        {
            this.IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
