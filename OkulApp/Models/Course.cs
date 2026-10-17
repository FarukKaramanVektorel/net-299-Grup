using System;
using System.Collections.Generic;
using System.Text;

namespace OkulApp.Models
{
   public class Course
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Credit { get; set; }

        public int DepartmentId { get; set; }

        public Department Department { get; set; }

        public List<Student> Students { get; set; } = new List<Student>();
    }
}
