using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalFinance
{
    public class AccountMapProfile : Profile
    {
        public AccountMapProfile()
        {
            CreateMap<AccountUpdateInput,Account>()
                .ForMember(a => a.Id, options => options.Ignore())
                .ForMember(a => a.Name, options =>options.MapFrom(input => input.Name))
                .ForMember(a => a.Description, options => options.MapFrom(input => input.Description));
        }
    }
}
