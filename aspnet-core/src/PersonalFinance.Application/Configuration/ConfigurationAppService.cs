using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using PersonalFinance.Configuration.Dto;

namespace PersonalFinance.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : PersonalFinanceAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
