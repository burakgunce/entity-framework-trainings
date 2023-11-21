using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanBakimiDataAnnotation.Models
{
    public class Yiyecek
    {
        public int YiyecekId { get; set; }
        public string Ad { get; set; }
        public string Icerik { get; set; }
        public int Kalori { get; set; }

        public ICollection<Hayvan> Hayvanlar { get; set; }
        
    }
}
