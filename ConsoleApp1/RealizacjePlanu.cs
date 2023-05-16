using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ConsoleApp1
{
    public class RealizacjaPlanu
    {
        [Key]
        [Column("re_ID")]
        public int re_ID { get; set; }
        public int re_ppID { get; set; }
        public DateTime re_Data { get; set; }
        public int re_Grupa { get; set; }
        public string re_Temat { get; set; }
        public string re_Uwagi { get; set; }
        public string re_Konspekt { get; set; }
        public string re_Status { get; set; }
        public PozycjePlanu pozycjePlanu { get; set; }

        public Grupy grupy { get; set; }

        public ICollection<Frekwencja> frekwencja { get; set; }
    }
}
