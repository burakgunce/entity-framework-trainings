using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationDbFluApi.Models
{
    public class Lesson
    {
        public int LesId { get; set; }
        public string Name { get; set; }

        public ICollection<Student> Students { get; set; }
    }
}
