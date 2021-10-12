using Abp.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalFinance
{
    public class AccountService : PersonalFinanceAppServiceBase, IAccountService
    {
        private readonly IRepository<Account> _accountRepository;

        public AccountService(IRepository<Account> accountRepository)
        {
            _accountRepository = accountRepository;
        }

        public async Task<List<AccountDTO>> GetAll(GetAllAccountInput input)
        {
            var accounts = await _accountRepository.GetAll()
                .Where(a => a.UserId == input.UserId)
                .ToListAsync();

            return new List<AccountDTO>(ObjectMapper.Map<List<AccountDTO>>(accounts));
        }
    }
}
