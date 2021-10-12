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
        #region DBSet definitions
        public DbSet<Account> Account { get; set; }
        public DbSet<Transaction> Transaction { get; set; }
        public DbSet<Transaction_Account> Transaction_Account { get; set; }
        public DbSet<UserApp> UserApp { get; set; } 
        #endregion

        public PersonalFinanceDbContext(DbContextOptions<PersonalFinanceDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            modelBuilder.Entity<Account>().ToTable("Accounts")
                .HasMany(a => a.Transactions)
                .WithOne(t =>t.Account)
                .HasForeignKey(t => t.TransactionId);

            modelBuilder.Entity<Transaction>()
                .ToTable("Transactions")
                .HasMany(a => a.Accounts)
                .WithOne(t => t.Transaction)
                .HasForeignKey(t => t.AccountId); 

            modelBuilder.Entity<Transaction_Account>()
                .ToTable("Transactions_Account")
                .HasAlternateKey(t=> new { t.TransactionId, t.AccountId });
            
        }
    }
}
