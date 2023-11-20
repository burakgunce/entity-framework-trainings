using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelationsEFCore.Models
{
    public class ProductDetail
    {
        public int ProductDetailId { get; set; }
        public string Color { get; set; }
        public int Height { get; set; }
        public int Widht { get; set; }
        public int ProductrefId { get; set; }
        public virtual Product Product { get; set; }
    }
}
