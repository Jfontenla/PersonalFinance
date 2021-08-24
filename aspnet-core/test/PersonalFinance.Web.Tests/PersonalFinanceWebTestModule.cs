using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using PersonalFinance.EntityFrameworkCore;
using PersonalFinance.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace PersonalFinance.Web.Tests
{
    [DependsOn(
        typeof(PersonalFinanceWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class PersonalFinanceWebTestModule : AbpModule
    {
        public PersonalFinanceWebTestModule(PersonalFinanceEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(PersonalFinanceWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(PersonalFinanceWebMvcModule).Assembly);
        }
    }
}