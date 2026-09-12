using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    class Yonetici:Person
    {
        public int Katsayi { get; set; }
        public string[] Birimler { get; set; }

        public Yonetici(string name, string lastName, DateTime birthDay, string meslek,int katsayi, string[] birimler):base(name,lastName,birthDay,meslek)
        {
            Katsayi = katsayi;
            Birimler = birimler;
        }

        public override double MaasHesapla()
        {
            return Katsayi * ASGARI_UCRET;
        }
    }
}
