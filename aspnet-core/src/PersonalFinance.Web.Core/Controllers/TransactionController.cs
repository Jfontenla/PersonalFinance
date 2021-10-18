using PersonalFinance.Sessions;
using PersonalFinance.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalFinance.Controllers 
{


    public class TransactionController : PersonalFinanceControllerBase
    {
        private readonly ITransactionService _transactionService;
        private readonly ISessionAppService _sessionAppService;
        private readonly IUserAppService _userAppService;

        public TransactionController(ITransactionService transactionService, ISessionAppService sessionAppService, IUserAppService userAppService)
        {
            _transactionService = transactionService;
            _sessionAppService = sessionAppService;
            _userAppService = userAppService;
        }

        public async Task<List<TransactionListDTO>> FindAllTransactionByAccount(int AccountId)
        {
            var input = new GetAllTransactionsByAccountInput();
            input.AccountId = AccountId;

            var result = await _transactionService.GetAll(input);

            return result;
        }

    }
}
