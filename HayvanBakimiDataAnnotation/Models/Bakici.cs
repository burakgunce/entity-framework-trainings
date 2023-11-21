using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanBakimiDataAnnotation.Models
{
    public class Bakici
    {
        public int BakiciId { get; set; }
        public string Ad { get; set; }

        public ICollection<Hayvan> Hayvanlar { get; set; }
    }
}
