using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarVillaProject.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace CarVillaProject.DAL.Contexts
{
    public class AppDbContext:DbContext
    {
  public  DbSet<Car> Cars { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        
        optionsBuilder.UseSqlServer(@"Server=localhost\SQLEXPRESS;Database=MvsCarArxt;Trusted_Connection=True;TrustServerCertificate=True;");
        base.OnConfiguring(optionsBuilder);

    }
    }
}
