using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    abstract class Person
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDay { get; set; }
        public string Meslek { get; set; }
        public static int CalisanSayisi { get; set; }
        public static readonly double ASGARI_UCRET = 28102.50;

        public Person(string name, string lastName, DateTime birthDay, string meslek)
        {
            Name = name;
            LastName = lastName;
            BirthDay = birthDay;
            Meslek = meslek;
            CalisanSayisi++;
        }

        public abstract double MaasHesapla();

        public override string ToString()
        {
            return $"Personel Adı: {Name} {LastName}, Mesleği: {Meslek}";
        }

        public override bool Equals(object obj)
        {
            Person p = (Person)obj;
            bool status =this.Name.Equals(p.Name)&&this.LastName.Equals(p.LastName)&&this.Meslek.Equals(p.Meslek);
            return status;
        }
    }
}
