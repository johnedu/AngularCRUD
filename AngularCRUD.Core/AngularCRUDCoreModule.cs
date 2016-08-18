namespace AngularCRUD
{
    using System.Reflection;

    using Abp.Modules;

    public class AngularCRUDCoreModule : AbpModule
    {
        public override void Initialize()
        {
            this.IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
