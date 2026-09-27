using System;
using System.Collections.Generic;
using System.Text;

namespace Exceptions
{
    class BankaHesabi
    {
        public double Bakiye { get; private set; } = 10000;

        public void ParaCek(double miktar)
        {
            if (miktar > Bakiye)
            {
                throw new YetersizBakiyeException("Bakiye Yetersiz", miktar - Bakiye);
            }
            Bakiye -= miktar;
            Console.WriteLine($"{miktar} TL tutarında para çekim işlemi gerçekleşti\nMevcut Bakiyeniz: {Bakiye} TL");
        }

    }
}
