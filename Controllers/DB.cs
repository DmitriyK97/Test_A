using System;
using Microsoft.EntityFrameworkCore;
namespace TestA.Controllers
{
    public class DB : DbContext
    {
        public DB()
        {
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
            Database.EnsureCreated();
        }

        public DbSet<ApiCheck> Histories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(
                $"Host=localhost;" +
                $"Port=5433;" +
                $"Database=test;" +
                "TimeZone=Asia/Yekaterinburg;" +
                $"Username=postgres;" +
                $"Password=admin;" +
                "Pooling=false;" +
                "Timeout=600;" +
                "CommandTimeout=600");
        }
    }
}
