using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_09_2026
{
    internal class Il
    {
        public int Plaka { get; set; }
        public string  Name { get; set; }

        public Il(int plaka, string name)
        {
            Plaka = plaka;
            Name = name;
        }

        internal string info()
        {
            return Name;
        }
    }
}
