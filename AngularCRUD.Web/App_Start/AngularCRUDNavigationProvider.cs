namespace AngularCRUD.Web
{
    using Abp.Application.Navigation;
    using Abp.Localization;

    /// <summary>
    /// This class defines menus for the application.
    /// It uses ABP's menu system.
    /// When you add menu items here, they are automatically appear in angular application.
    /// See .cshtml and .js files under App/Main/views/layout/header to know how to render menu.
    /// </summary>
    public class AngularCRUDNavigationProvider : NavigationProvider
    {
        public override void SetNavigation(INavigationProviderContext context)
        {
            context.Manager.MainMenu
                .AddItem(
                    new MenuItemDefinition(
                        "Home",
                        new LocalizableString("HomePage", AngularCRUDConsts.LocalizationSourceName),
                        url: "#/",
                        icon: "fa fa-home"))
                .AddItem(
                    new MenuItemDefinition(
                        "menu_admin_persons",
                        new LocalizableString("PersonsPage", AngularCRUDConsts.LocalizationSourceName),
                        url: "#/admin/persons",
                        icon: "fa fa-users"));
        }
    }
}
