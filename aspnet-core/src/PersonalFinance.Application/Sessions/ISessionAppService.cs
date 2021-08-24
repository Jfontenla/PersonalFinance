using System.Threading.Tasks;
using Abp.Application.Services;
using PersonalFinance.Sessions.Dto;

namespace PersonalFinance.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
