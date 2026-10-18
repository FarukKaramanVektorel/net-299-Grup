using System;
using System.Collections.Generic;
using System.Text;

namespace OkulApp.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string  LastName { get; set; }
        public string  Phone { get; set; }
        public int Age { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }

        public List<Course> Courses { get; set; }=new List<Course>();
    }
}
