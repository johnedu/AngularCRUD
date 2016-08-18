namespace AngularCRUD
{
    using System.Data.Entity;
    using System.Reflection;

    using Abp.EntityFramework;
    using Abp.Modules;

    using AngularCRUD.EntityFramework;

    [DependsOn(typeof(AbpEntityFrameworkModule), typeof(AngularCRUDCoreModule))]
    public class AngularCRUDDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            this.Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            this.IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
            Database.SetInitializer<AngularCRUDDbContext>(null);
        }
    }
}
