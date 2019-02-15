using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banking.Data;
using Banking.Models;

namespace Banking.Views
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
      using (BankingDbContext db = new BankingDbContext(ServerName: "(Local)", DatabaseName: "Banking_Dev"))
      {
        string Sql = "SELECT [ImportDate], COUNT(*) AS 'Count', SUM([Amount]) AS 'Amount' " +
          "FROM Import GROUP BY[ImportDate]";
        try
        {
          //var importCounts = db.Import
          //  .FromSql(Sql)
          //  .ToList();
          var importCounts = db.Import
            .Select(x => x.ImportDate)
            .Count();
        }
        catch (Exception ex)
        {
          throw ex;
        }

        foreach (var row in ImportCounts)
        {
          //_ImportCounts.Add(new ImportCount
          //{
          //  ImportDate = row.ImportDate,
          //  Count = row.Count,
          //  Amount = row.Amount
          //});
        }
      }
    }

    public static implicit operator List<object>(ImportOverview v)
    {
      throw new NotImplementedException();
    }
  }
}
