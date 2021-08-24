using Abp.Application.Services.Dto;

namespace PersonalFinance.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

