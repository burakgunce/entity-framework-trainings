using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationDbFluApi.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }

        public School School { get; set; }
        public int SchoolId { get; set; }

        public ICollection<Lesson> Lessons { get; set; }

        public Laptop Laptop { get; set; }
        public int LaptopId { get; set; }
    }
}
