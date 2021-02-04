using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Course
    {
        public int IdCourse { get; set; }
        public string Description { get; set; }
        public int MaxNumber { get; set; }
    }
}
