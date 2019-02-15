using ConsoleApp_1907401.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_1907401.Data
{
  public class BankingDbContext : DbContext
  {
    public BankingDbContext() { }

    public BankingDbContext(DbContextOptions<BankingDbContext> options) : base(options) { }

    public DbSet<Import> Import { get; set; }
    public DbSet<ImportCount> ImportQuery { get; set;}

    //ToDo: Make the ServerName a variable (Data Source=...)
    //ToDo: Make DatabaseName a variable (Database=...)
    //public BankingDbContext() : base("Trusted_Connection=True;Data Source=(Local);Database=Banking_Dev;" +
    //"MultipleActiveResultSets=true") { }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      if (!optionsBuilder.IsConfigured)
      {
        optionsBuilder.UseSqlServer("Server=(local);Database=Banking_Dev;Trusted_Connection=True;");
      }
    }
  }
}
