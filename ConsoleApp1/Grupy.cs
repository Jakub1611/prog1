using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ConsoleApp1
{
    public class Grupy
    {
        [Key]
        [Column("gr_ID")]
        public int gr_ID { get; set; }
        public int gr_Kod_grupy { get; set; }
        public string gr_Typ { get; set; }
        public string gr_Kierunek { get; set; }
        public int gr_Semestr { get; set; }
        public int gr_Rok_akad { get; set; }
        public string gr_Tryb_stud { get; set; }
        public int gr_Stopien_stud { get; set; }
        public string gr_Status { get; set; }
        public RealizacjaPlanu realizacjaPlanu { get; set; }
        public ObsadaGrup obsadaGrup { get; set; }
    }
}
