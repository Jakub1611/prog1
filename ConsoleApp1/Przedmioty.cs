using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1
{
    public class Przedmioty
    {
        [Key]
        [Column("pr_ID")]
        public int pr_ID { get; set; }
        public string pr_Nazwa { get; set; }
        public string pr_Typ { get; set; }
        public int pr_Liczba_h_tyg { get; set; }
        public string pr_Kierunek { get; set; }
        public string pr_Semestr { get; set; }
        public string pr_Kod_sylabusa { get; set; }
        public int pr_Rok_akademicki { get; set; }
        public string pr_Status { get; set; }

        public PozycjePlanu pozycjePlanu { get; set; }
    }
}
