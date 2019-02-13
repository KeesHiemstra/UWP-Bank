using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.Models
{
  public class ImportCount
  {
    public DateTime ImportDate { get; set; }
    public int Count { get; set; }
    public decimal Amount { get; set; }
  }
}
