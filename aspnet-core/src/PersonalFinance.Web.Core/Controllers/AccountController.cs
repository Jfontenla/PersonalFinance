using Microsoft.AspNetCore.Mvc;
using PersonalFinance.Sessions;
using PersonalFinance.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalFinance.Controllers
{
    public class AccountController :PersonalFinanceControllerBase
    {
        //private readonly IAccountService _iAccountService;
        //private readonly ISessionAppService _iSessionAppService;
        //private readonly IUserAppService _iUserAppService;

        //public AccountController(IAccountService iAccountService, ISessionAppService iSessionAppService, IUserAppService iUserAppService)
        //{
        //    _iAccountService = iAccountService;
        //    _iSessionAppService = iSessionAppService;
        //    _iUserAppService = iUserAppService;
        //}

        //public async Task<List<AccountDTO>> FindAllAccountsByUser()
        //{
        //    var input = new GetAllAccountInput();
        //    var result = new List<AccountDTO>();

        //    input.UserId =await _iUserAppService.GetUserId(_iSessionAppService.GetCurrentLoginInformations().Result.User.EmailAddress);
            
        //    result.AddRange(await _iAccountService.GetAll(input));
            
        //    return result;
        //}

        //public async Task<AccountDTO> CreateAccount(AccountCreateInput input)
        //{
        //    try
        //    {
        //        var result = await _iAccountService.CreateAccount(input);

        //        return result;
        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }
        //}

        //public async Task<AccountDTO> UpdateAccount(AccountUpdateInput input)
        //{
        //    var result = await _iAccountService.UpdateAccount(input);
            
        //    return result;
        //}

        //public async Task<AccountDTO> UpdateToDisableAccount(AccountActivateInput input) 
        //{
        //    var result = await _iAccountService.UpdateToDisableAccount(input);

        //    return result;
        //}
    }
}
