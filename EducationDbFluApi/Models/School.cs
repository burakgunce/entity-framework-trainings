using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationDbFluApi.Models
{
    public class School
    {
        public int SchoolId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public ICollection<Student> Students { get; set; }
    }
}
