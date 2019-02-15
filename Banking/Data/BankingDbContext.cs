using Banking.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.Data
{
  public class BankingDbContext : DbContext
  {
    public DbSet<Import> Import { get; set; }
    public DbSet<ImportCount> ImportQuery { get; set; }

    public BankingDbContext(string ServerName, string DatabaseName) : 
      base($"Trusted_Connection=True;MultipleActiveResultSets=true;" +
        $"Data Source={ServerName};" +
        $"Database={DatabaseName};") { }
  }
}
