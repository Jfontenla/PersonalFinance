using Abp.Application.Services;
using PersonalFinance.MultiTenancy.Dto;

namespace PersonalFinance.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

