using Microsoft.EntityFrameworkCore;

namespace EF
{
    public class AppContext : DbContext
    {
        // Объекты таблицы Users
        public DbSet<User> Users { get; set; }

        // Объекты таблицы Companies
        public DbSet<Company> Companies { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=EF;User Id=SA;Password=reallyStrongPwd123;TrustServerCertificate=true");
        }
    }
}

