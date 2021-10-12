using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalFinance
{
    public interface IAccountService
    {
        Task<List<AccountDTO>> GetAll(GetAllAccountInput input);
    }
}
