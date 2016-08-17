using Abp.Application.Navigation;
using Abp.Localization;

namespace SuperPowers.Web
{
    /// <summary>
    /// This class defines menus for the application.
    /// It uses ABP's menu system.
    /// When you add menu items here, they are automatically appear in angular application.
    /// See .cshtml and .js files under App/Main/views/layout/header to know how to render menu.
    /// </summary>
    public class SuperPowersNavigationProvider : NavigationProvider
    {
        public override void SetNavigation(INavigationProviderContext context)
        {
            context.Manager.MainMenu
                .AddItem(
                    new MenuItemDefinition(
                        "Home",
                        new LocalizableString("HomePage", AngularCRUDConsts.LocalizationSourceName),
                        url: "#/",
                        icon: "fa fa-home"));
        }
    }
}
