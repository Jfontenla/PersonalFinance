using Microsoft.Extensions.Configuration;
using Castle.MicroKernel.Registration;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using PersonalFinance.Configuration;
using PersonalFinance.EntityFrameworkCore;
using PersonalFinance.Migrator.DependencyInjection;

namespace PersonalFinance.Migrator
{
    [DependsOn(typeof(PersonalFinanceEntityFrameworkModule))]
    public class PersonalFinanceMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public PersonalFinanceMigratorModule(PersonalFinanceEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(PersonalFinanceMigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                PersonalFinanceConsts.ConnectionStringName
            );

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(
                typeof(IEventBus), 
                () => IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                )
            );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(PersonalFinanceMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}
