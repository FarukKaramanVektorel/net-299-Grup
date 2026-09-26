using System;
using System.Collections.Generic;
using System.Text;

namespace LinqToObject
{
    class Bolum
    {
        public Bolum(int ıd, string name)
        {
            Id = ıd;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return $"ID: {Id}, Ad: {Name}";
        }
        public override bool Equals(object? obj)
        {
            if (!(obj is Bolum b))
            {
                return false;
            }
            else
            {
                return Id == b.Id && Name.Equals(b.Name);
            }

        }


    }
}
