namespace AngularCRUD
{
    using System;
    using System.Linq;
    using System.Reflection;

    using Abp.Modules;

    using AngularCRUD.Utilities.AutoMapper;

    using AutoMapper;

    using SuperPowers;

    [DependsOn(typeof(AngularCRUDCoreModule))]
    public class AngularCRUDApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            this.IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
            this.InitilizeAutoMapper();
        }

        private void InitilizeAutoMapper()
        {
            Mapper.Initialize(x =>
            {
                var profiles = typeof(AutoMapperBaseProfile).Assembly.GetTypes().Where(perfil => perfil.IsSubclassOf(typeof(AutoMapperBaseProfile)));
                foreach (var perfil in profiles)
                {
                    x.AddProfile((AutoMapperBaseProfile)Activator.CreateInstance(perfil));
                }
            });
        }
    }
}