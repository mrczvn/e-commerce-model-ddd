using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Configuration
{
    public class ContextBase : DbContext
    {
        public ContextBase(DbContextOptions<ContextBase> options) : base(options)
        {
        }

        public DbSet<Product> Product { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(GetStringConnnectionConfig());
                base.OnConfiguring(optionsBuilder);
            }
        }

        private string GetStringConnnectionConfig()
        {
            string connectionString = "Server=192.168.99.100;Database=TestMysql;UserId=MainUser;Password=my-secret-pw;";

            return connectionString;
        }
    }
}