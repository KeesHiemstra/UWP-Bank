using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.Data
{
  public class ImportDBContext : DBContext
  {
    public ImportDBContext() : base("Trusted_Connection=True;Data Source=(Local);Database=Banking_Dev;MultipleActiveResultSets=true") { }

    public DbSet<ImportModel> Import { get; set; }

    internal static void SeedData(ImportDbContext context)
    {
      context.Database.CreateIfNotExists();
    }

  }
}
