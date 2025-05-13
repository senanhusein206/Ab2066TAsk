using Microsoft.EntityFrameworkCore;
using WebApplication3.Models;

namespace WebApplication3.Contexts
{
    public class AppDbContext:DbContext
    {
        private readonly string _configName= @"Server=localhost\SQLEXPRESS;Database=ABmvsssss;Trusted_Connection=True;TrustServerCertificate=True;";
        public DbSet<Product> Products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_configName);
            base.OnConfiguring(optionsBuilder);
            
        }
    }
}
