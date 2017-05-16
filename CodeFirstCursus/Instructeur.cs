using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CodeFirstCursus
{
    public class Instructeur
    {
        [Key]
        public int InstructeurNr { get; set; }
        public string Voornaam { get; set; }
        public string Familienaam { get; set; }
        public Adres Adres { get; set; }
        [Column("maandwedde")]
        public decimal Wedde { get; set; }
        [Column(TypeName = "date")]
        public DateTime InDienst { get; set; }
        public bool? HeeftRijbewijs { get; set; }
        public virtual Campus Campus { get; set; }
        public int CampusId { get; set; }
        public virtual ICollection<Verantwoordelijkheid> Verantwoordelijkheden { get; set; }
        public void Opslag(decimal percentage)
        {
            Wedde *= (1M + percentage / 100M);
        }
    }
}
