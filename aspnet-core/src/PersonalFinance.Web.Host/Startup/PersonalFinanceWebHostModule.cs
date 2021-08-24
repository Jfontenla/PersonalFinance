using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using PersonalFinance.Configuration;

namespace PersonalFinance.Web.Host.Startup
{
    [DependsOn(
       typeof(PersonalFinanceWebCoreModule))]
    public class PersonalFinanceWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public PersonalFinanceWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(PersonalFinanceWebHostModule).GetAssembly());
        }
    }
}
