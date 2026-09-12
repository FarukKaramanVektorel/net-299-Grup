using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cloks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Saat sınıfı ve alt sınıflarını oluşturarak
            // abstraction kullanın

            WallClock duvarSaati = new WallClock(58, 59, 12);
            SmartClock akilliSaat = new SmartClock(0,"Android",58, 59, 12);
            akilliSaat.ilerle(80);
            akilliSaat.saatGoster();
            duvarSaati.ilerle(80);
            duvarSaati.saatGoster();
        }
    }
}
