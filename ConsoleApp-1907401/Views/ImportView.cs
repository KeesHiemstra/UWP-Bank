using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp_1907401.Models;
using ConsoleApp_1907401.Data;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp_1907401.Views
{
  public class ImportOverview
  {
    private ObservableCollection<ImportCount> _ImportCounts = new ObservableCollection<ImportCount>();
    public ObservableCollection<ImportCount> ImportCounts
    {
      get => _ImportCounts;
      set => _ImportCounts = value;
    }
    public int ImportCount { get => _ImportCounts.Count; }

    public ImportOverview()
    {
      _ImportCounts = ImportCounts;

      QueryImports();
    }

    private void QueryImports()
    {
      using (BankingDbContext db = new BankingDbContext())
      {
        string Sql = "SELECT [ImportDate], COUNT(*) AS 'Count', SUM([Amount]) AS 'Amount' " +
          "FROM Import GROUP BY [ImportDate]";
        //var importCounts = db.Import.SqlQuery(Sql);
        var importCounts = db.ImportQuery
          .FromSql(Sql)
          .ToList();

        foreach (var row in importCounts)
        {
          _ImportCounts.Add(new ImportCount
          {
            ImportDate = row.ImportDate,
            //Count = row.Count,
            Amount = row.Amount
          });
        }
      }
    }
  }
}
