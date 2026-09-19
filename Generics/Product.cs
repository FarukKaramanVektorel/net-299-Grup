using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Product
    {
        public string Name { get; set; }

        public double AlisFiyati { get; set; }

        public Product(string name, double alisFiyati)
        {
            Name = name;
            AlisFiyati = alisFiyati;
        }

        public virtual void Maliyet() {
            double maliyet = AlisFiyati * 1.2;
            Console.WriteLine("Bu ürünün maliyeti :"+maliyet+" TL dir...");
        }

        public override string ToString()
        {
            return $"Ürün Adı: {Name}";
        }
    }
}
