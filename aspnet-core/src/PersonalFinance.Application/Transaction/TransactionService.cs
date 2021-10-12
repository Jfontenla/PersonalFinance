using Abp.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalFinance
{
    public class TransactionService : PersonalFinanceAppServiceBase, ITransactionService
    {
        private readonly IRepository<Transaction> _transactionRepository;

        public TransactionService(IRepository<Transaction> transactionRepository)
        {
            _transactionRepository = transactionRepository;
        }

        public async Task<List<TransactionListDTO>> GetAll(GetAllTransactionsByUserInput input)
        {
            var transactions = await _transactionRepository.GetAll()
                .Include(t => t.Accounts)
                    .ThenInclude( a => a.Account)
                    .ThenInclude( a => a.User)
                .Where(t => t.Accounts.Select(a => a.Account.UserId).Contains(input.UserId))
                .ToListAsync();

            return new List<TransactionListDTO>(ObjectMapper.Map<List<TransactionListDTO>>(transactions));
        }
    }
}
