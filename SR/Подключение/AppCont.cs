using System;
using Microsoft.EntityFrameworkCore;

namespace SR
{
	public class AppCont : DbContext
	{
		public DbSet<User> Users { get; set; }
		public DbSet<Book> Books { get; set; }
        public DbSet<BookInfo> BooksInfo { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=SR;User Id=SA;Password=reallyStrongPwd123;TrustServerCertificate=true");
        }
    }
}

