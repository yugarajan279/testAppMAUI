using Microsoft.EntityFrameworkCore;
using testapp;

namespace testapp.Data
{
    public class DatabaseContext : DbContext
    {
        private readonly string _connectionString;

        public DatabaseContext(string connectionString)
        {
            _connectionString = connectionString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }

        public DbSet<SecurityAuthentication> SecurityAuthentications { get; set; }
    }
}
