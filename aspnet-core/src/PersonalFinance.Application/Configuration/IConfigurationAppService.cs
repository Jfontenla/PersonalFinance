using System.Threading.Tasks;
using PersonalFinance.Configuration.Dto;

namespace PersonalFinance.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
