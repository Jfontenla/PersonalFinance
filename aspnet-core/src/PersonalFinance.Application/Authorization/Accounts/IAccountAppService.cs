using System.Threading.Tasks;
using Abp.Application.Services;
using PersonalFinance.Authorization.Accounts.Dto;

namespace PersonalFinance.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
