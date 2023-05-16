using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace ConsoleApp1
{
    public class ObsadaGrup
    {
        [Key]
        [Column("Ob_ID")]
        public int ob_ID { get; set; }
        public int ob_stID { get; set; }
        public DateTime ob_Data_od { get; set; }
        public DateTime? ob_Data_do { get; set; }
        public string ob_Status { get; set; }

        public ICollection<Studenci> Studenci { get; set; }
        public Grupy grupy { get; set; }
    }

}
