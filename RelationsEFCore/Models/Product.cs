using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelationsEFCore.Models
{
    public class Product
    {
        public Product()
        {
            Date = DateTime.Now;
        }
        public int ProductId { get; set; }
        public string Name { get; set; }
        public int StockAmount { get; set; }
        public double UnitPrice { get; set; }
        public DateTime Date { get; set; }
        public int CategoryRefId { get; set; }
        public virtual Category Category { get; set; }
        public virtual ProductDetail ProductDetail { get; set; }
    }
}
