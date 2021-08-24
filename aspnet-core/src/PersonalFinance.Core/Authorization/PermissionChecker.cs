using Abp.Authorization;
using PersonalFinance.Authorization.Roles;
using PersonalFinance.Authorization.Users;

namespace PersonalFinance.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
