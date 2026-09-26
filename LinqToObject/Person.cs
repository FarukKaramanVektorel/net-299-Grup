using System;
using System.Collections.Generic;
using System.Text;

namespace LinqToObject
{
    class Person
    {
        public Person(string name, string lastName, double salary)
        {
            Name = name;
            LastName = lastName;
            Salary = salary;
        }

        public string Name { get; set; }
        public string LastName { get; set; }
        public double Salary { get; set; }

        public override string ToString()
        {
            return $"{Name} {LastName}, {Salary:C2}";
        }
    }
}
