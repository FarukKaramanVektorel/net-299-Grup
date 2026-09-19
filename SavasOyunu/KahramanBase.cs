using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavasOyunu
{
    class KahramanBase
    {
        public string  Name { get; set; }
        public double Hiz { get; set; }
        public double Guc { get; set; }
        public double  Saglik { get; set; }
        public double IyilesmeOrani { get; set; }

        public KahramanBase(string name, double hiz, double guc, double saglik, double ıyilesmeOrani)
        {
            Name = name;
            Hiz = hiz;
            Guc = guc;
            Saglik = saglik;
            IyilesmeOrani = ıyilesmeOrani;
        }
        public void Saldir<TCanavar>(TCanavar canavar) where TCanavar:CanavarBase
        {
            if (Saglik <= 0)
            {
                Console.WriteLine($"{Name} yenildi...");
                return;
            }
            double hasar = HasarHesapla();
            Console.WriteLine($"{Name} => {canavar.Name} canavarına {hasar:f1} ile saldırdı...");
            canavar.HasarAl(hasar);
            if (canavar.Saglik <= 0)
            {
                Console.WriteLine($"{canavar.Name} yenildi...");
            }

        }

        public void HasarAl(double hasar)
        {
            Saglik -= hasar;
            Console.WriteLine($"{Name} {hasar} aldı...");
        }

        public virtual double HasarHesapla()
        {
            return (Guc / Saglik) * 20; 
        }

        public void Iyilesme()
        {
            Saglik += IyilesmeOrani * Hiz;
            Console.WriteLine($"{Name} iyileşti, {Saglik:F1}");
        }
    }
}
