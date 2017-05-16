using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstCursus
{
    [Table("KlassikaleCursussen")]
    public class KlassikaleCursus : Cursus
    {
        public DateTime Van { get; set; }
        public DateTime Tot { get; set; }
    }
}
