using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavasOyunu
{
    class CanavarBase
    {
        public string Name { get; set; }
        public double Guc { get; set; }
        public double Savunma { get; set; }
        public double Saglik { get; set; }

        public CanavarBase(string name, double guc, double savunma, double saglik)
        {
            Name = name;
            Guc = guc;
            Savunma = savunma;
            Saglik = saglik;
        }

        public virtual double HasarHesapla()
        {
            return (Guc/Saglik)*20;
        }

        public void Saldir<TKahraman>(TKahraman kahraman) where TKahraman : KahramanBase
        {
            if (Saglik <= 0)
            {
                Console.WriteLine($"{Name} yenildi...");
                return;
            }

            double hasar=HasarHesapla();

            Console.WriteLine($"{Name} => {kahraman.Name} saldırıyor...");
            kahraman.HasarAl(hasar);

            if (kahraman.Saglik <= 0)
            {
                Console.WriteLine($"{kahraman.Name} yenildi...");
            }
            
        }

        public void HasarAl(double gelenHasar)
        {
            double hasar = Math.Max(0,gelenHasar- Savunma);

            Saglik -= hasar;
            Console.WriteLine($"{Name} {hasar:F1} hasar aldı, sağlık: {Saglik:F1}");

        }
    }
}
