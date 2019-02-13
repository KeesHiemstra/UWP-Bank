using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banking.Models;
using Microsoft.SqlServer;

namespace Banking.Views
{
  public class ImportOverview
  {
    private static List<ImportCount> _ImportCounts;

    public ImportOverview(List<ImportCount> ImportCounts)
    {
      _ImportCounts = ImportCounts;

      
    }
  }
}
