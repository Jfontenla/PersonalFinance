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

        public async Task<AccountDTO> CreateAccount(AccountCreateInput input)
        {
            return ObjectMapper.Map<AccountDTO>(await _accountRepository.InsertAsync(ObjectMapper.Map<Account>(input)));
        }

        public async Task<AccountDTO> UpdateAccount(AccountUpdateInput input)
        { 
            var accountToUpdate = await _accountRepository.GetAsync(input.Id);

            return ObjectMapper.Map<AccountDTO>(await _accountRepository.UpdateAsync(ObjectMapper.Map(input ,accountToUpdate)));
        }

        public async Task<AccountDTO> UpdateToDisableAccount(AccountActivateInput input)
        {
            var account = await _accountRepository.GetAsync(input.Id);
            account.Disable();
            return ObjectMapper.Map<AccountDTO>(await _accountRepository.UpdateAsync(account));
        }
    }
}
