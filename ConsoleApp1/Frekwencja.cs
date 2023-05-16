using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1
{
    public class Frekwencja

    {
     [Key]
     [Column("fr_relID")]
    public int fr_relID { get; set; }
    public int fr_stID { get; set; }
    public bool fr_Obecny { get; set; }
    public string fr_Notatka { get; set; }
    public string fr_Status { get; set; }

    public RealizacjaPlanu realizacjaPlanu { get; set; }
    public Studenci studenci { get; set; }
}
}
