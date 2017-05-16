using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CodeFirstCursus
{
    [Table("Campussen")]
    public class Campus
    {
        public int CampusId { get; set; }
        [Required, StringLength(50)]
        public string Naam { get; set; }
        public Adres Adres { get; set; }
        public virtual ICollection<Instructeur> Instructeurs { get; set; }
    }
}
