using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CodeFirstCursus
{
    [Table("Cursisten")]
    public class Cursist
    {
        [Key]
        public int CursistId { get; set; }
        public string Voornaam { get; set; }
        public string Familienaam { get; set; }
        public virtual ICollection<Cursist> Beschermelingen { get; set; }
        [InverseProperty("Beschermelingen"), ForeignKey("MentorId")]
        public virtual Cursist Mentor { get; set; }
        public int? MentorId { get; set; }
    }
}
