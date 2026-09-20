using System;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    class Student
    {
        

        public string Name { get; set; }
        public string Number { get; set; }

        public Student(string name, string number)
        {
            Name = name;
            Number = number;
        }

        public override string ToString()
        {
            return $"Öğrenci No: {Number}, Adı: {Name}";
        }


    }
}
