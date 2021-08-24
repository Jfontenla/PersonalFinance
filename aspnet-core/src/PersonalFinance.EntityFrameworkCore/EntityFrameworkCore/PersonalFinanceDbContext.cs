using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using PersonalFinance.Authorization.Roles;
using PersonalFinance.Authorization.Users;
using PersonalFinance.MultiTenancy;

namespace PersonalFinance.EntityFrameworkCore
{
    public class PersonalFinanceDbContext : AbpZeroDbContext<Tenant, Role, User, PersonalFinanceDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public PersonalFinanceDbContext(DbContextOptions<PersonalFinanceDbContext> options)
            : base(options)
        {
        }
    }
}
