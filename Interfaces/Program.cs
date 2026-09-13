using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Mp3 mp3 = new Mp3("Sabahçı Kahvesi","Ferdi Tayfur",-3.45);
           Mp3 mp32 = new Mp3("Yıldızlarda Kayar","Ferdi Tayfur",3.25);
            mp3.Sure = -89;
            Teyp otoTeyp=new Teyp();
            otoTeyp.start(mp3);
            Wolkman w = new Wolkman();
            w.start(mp32);
            SmartPhone sp = new SmartPhone();
            sp.start(mp32);
            int sure=mp3.sureHesapla();
            otoTeyp.bisey();
            Console.ReadLine();
        }
    }
}
