using System.Reflection;
using Abp.Modules;

namespace SuperPowers
{
    public class AngularCRUDCoreModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
