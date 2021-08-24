using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace PersonalFinance.EntityFrameworkCore
{
    public static class PersonalFinanceDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<PersonalFinanceDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<PersonalFinanceDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
