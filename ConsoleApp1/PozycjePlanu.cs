using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ConsoleApp1
{
    public class PozycjePlanu
    {
        [Key]
        [Column("pp_ID")]
        public int pp_ID { get; set; }
        public int pp_Nazwa { get; set; }
        public Przedmioty Przedmioty { get; set; }
        public int pp_Grupa { get; set; }
        public string pp_Sala { get; set; }
        public DateTime pp_Dzień { get; set; }
        public TimeSpan pp_Godzina_od { get; set; }
        public TimeSpan pp_Godzina_do { get; set; }
        public string pp_Status { get; set; }
        public float pp_Liczba_godzin { get; set; }
        public RealizacjaPlanu realizacjaPlanu { get; set; }
        public Przedmioty przedmioty { get; set; }
    }
}
