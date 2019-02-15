using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_1907401.Models
{
  [Table("Import")]
  public class Import
  {
    [Key]
    public int Id { get; set; }

    [Required]
    //[Editable(false)]
    [DataType(DataType.DateTime)]
    public System.DateTime ImportDate { get; set; }

    [Required]
    //[Editable(false)]
    public string Account { get; set; }

    [Required]
    //[Editable(false)]
    [DataType(DataType.Date)]
    public System.DateTime Date { get; set; }

    [Required]
    //[Editable(false)]
    public string Mutation { get; set; }

    [Required]
    //[Editable(false)]
    public decimal Amount { get; set; }

    //[Editable(false)]
    public string Name { get; set; }

    //[Editable(false)]
    public string CounterAccount { get; set; }

    //[Editable(false)]
    public string Text { get; set; }

    public string Month { get; set; }

    public string Origin { get; set; }

    public string TallyName { get; set; }

    public string TallyDescription { get; set; }

    //[Editable(false)]
    public string RawText { get; set; }
  }
}
