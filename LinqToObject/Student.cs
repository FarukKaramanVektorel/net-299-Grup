using System;
using System.Collections.Generic;
using System.Text;

namespace LinqToObject
{
    class Student
    {
       

        public string FullName { get; set; }
        public string Number { get; set; }
        public string Phone { get; set; }
        public string Gender { get; set; }
        public int Bolum { get; set; }
        public Student(string fullName, string number, string phone, string gender, int bolum)
        {
            FullName = fullName;
            Number = number;
            Phone = phone;
            Gender = gender;
            Bolum = bolum;
        }

        public override string ToString()
        {
            return $"Öğrenci No: {Number}, Ad: {FullName} Telefon: {Phone}, Cinsiyet: {Gender}, Bölüm: {Bolum}";
        }

    }
}
