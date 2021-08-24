using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace PersonalFinance.Controllers
{
    public abstract class PersonalFinanceControllerBase: AbpController
    {
        protected PersonalFinanceControllerBase()
        {
            LocalizationSourceName = PersonalFinanceConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
