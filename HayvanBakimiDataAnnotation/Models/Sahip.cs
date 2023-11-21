using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanBakimiDataAnnotation.Models
{
    [Table("Owner")]
    public class Sahip
    {
        public int SahipId { get; set; }
        public string Ad { get; set; }

        public ICollection<Hayvan> Hayvanlar { get; set; }
    }
}
