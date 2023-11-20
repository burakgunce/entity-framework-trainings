using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManyToManyEfCore.Models
{
    public class Student
    {
        public Student()
        {
            this.Courses = new HashSet<Course>();
        }
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public ICollection<Course> Courses { get; set; }
    }
}
