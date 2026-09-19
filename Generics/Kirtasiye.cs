using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Kirtasiye : Product
    {
        public Kirtasiye(string name, double alisFiyati) : base(name, alisFiyati)
        {
        }

        public override void Maliyet()
        {
            double maliyet = AlisFiyati * 1.08;
            Console.WriteLine($"Maliyet: {maliyet} TL dir...");
        }
    }
}
