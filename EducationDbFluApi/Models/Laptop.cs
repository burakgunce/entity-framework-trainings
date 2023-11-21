using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationDbFluApi.Models
{
    public class Laptop
    {
        public int LaptopId { get; set; }
        public string Model { get; set; }
        public string Brand { get; set; }

        public Student Student { get; set; }
        //public int StudentId { get; set; } // foreign key için iki yerde yazmaya gerek yok sadece 1 yerde olması yeterli lapId stu da dursun
    }
}
