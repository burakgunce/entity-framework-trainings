﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManyToManyEfCore.Models
{
    public class Course
    {
        public Course()
        {
            this.Students = new HashSet<Student>();
        }
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}
