using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1
{
    public class Studenci
    {
        [Key]
        [Column("st_ID")]
        public int st_ID { get; set; }                              
        public string st_Imię { get; set; }
        public string st_Nazwisko { get; set; }
        public DateTime st_Rocznik_1s { get; set; }
        public string st_email { get; set; }
        public string st_Status { get; set; }

        public ICollection<Frekwencja> frekwencja { get; set; }
        public ObsadaGrup obsadaGrup { get; set; }
    }
}
