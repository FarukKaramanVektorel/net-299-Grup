using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    class PazarlamaPersoneli:Person
    {
        public PazarlamaPersoneli(double satisMiktari,string name, string lastName, DateTime birthDay, string meslek) : base(name, lastName, birthDay, meslek)
        {
            SatisMiktari = satisMiktari;
        }

        public double SatisMiktari { get; set; }

        public override double MaasHesapla()
        {
            return (SatisMiktari * 0.05) + ASGARI_UCRET;
        }
    }
}
