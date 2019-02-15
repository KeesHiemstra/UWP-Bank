using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp_1907401.Views;

/*
 * This tool is used to check the database use is working.
 */

namespace ConsoleApp_1907401
{
  class Program
  {
    static void Main(string[] args)
    {
      ImportOverview Imports = new ImportOverview();

      Console.WriteLine($"Rows: {Imports.ImportCount}");

      Console.Write("Press any key...");
      Console.ReadKey();
    }
  }
}
