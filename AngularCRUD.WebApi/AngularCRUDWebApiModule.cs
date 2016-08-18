namespace AngularCRUD
{
    using System.Reflection;

    using Abp.Application.Services;
    using Abp.Modules;
    using Abp.WebApi;
    using Abp.WebApi.Controllers.Dynamic.Builders;

    [DependsOn(typeof(AbpWebApiModule), typeof(AngularCRUDApplicationModule))]
    public class AngularCRUDWebApiModule : AbpModule
    {
        public override void Initialize()
        {
            this.IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            DynamicApiControllerBuilder
                .ForAll<IApplicationService>(typeof(AngularCRUDApplicationModule).Assembly, "app")
                .Build();
        }
    }
}
