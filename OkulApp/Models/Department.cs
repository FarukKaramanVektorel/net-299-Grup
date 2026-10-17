using System;
using System.Collections.Generic;
using System.Text;

namespace OkulApp.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string DapartmentName { get; set; }

        public List<Student> Students { get; set; } = new List<Student>();

        public List<Course> Courses { get; set; } = new List<Course>();
    }
}
