using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cloks
{
    internal class SmartClock : Clock
    {
        public int AdimSayisi { get; set; }
        public string IsletimSistemi { get; set; }

        public SmartClock(int adimSayisi, string isletimSistemi, int hour, int minute, int second)
            : base(hour, minute, second)
        {
            AdimSayisi = adimSayisi;
            IsletimSistemi = isletimSistemi;
        }

        public override void saatGoster()
        {
            Console.WriteLine($"Akıllı Saat: {Hour}:{Minute}:{Second}");
        }
    }
}
