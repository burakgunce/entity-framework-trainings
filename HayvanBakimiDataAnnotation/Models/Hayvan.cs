using HayvanBakimiDataAnnotation.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanBakimiDataAnnotation.Models
{
    public class Hayvan
    {
        //[Key]
        public int HayId { get; set; }
        public string Ad { get; set; }
        public Cinsiyet Cinsiyet { get; set; }
        public bool SahibiVarMi { get; set; }
        public DateTime DogumTarihi { get; set; }
        public int Agirlik { get; set; }
        public string Tur { get; set; }
        public string Cins { get; set; }
        public int Yas { get; set; }

        public ICollection<Yiyecek> Yiyecekler { get; set; }
        public Bakici Bakici { get; set; }
        public int BakiciId { get; set; }

        public Sahip Sahip { get; set; }

        [ForeignKey("Sahip")] //30. satırdaki property ismini içeri yaz
        [DisplayName("SahipFK")]
        public int SahipId { get; set; }


    }
}
