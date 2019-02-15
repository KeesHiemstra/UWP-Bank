﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.Models
{
  public class ImportCount
  {
    [Key]
    public DateTime ImportDate { get; set; }
    public int Count { get; set; }
    public decimal Amount { get; set; }
  }
}
