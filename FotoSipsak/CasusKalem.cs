using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FotoSipsak
{
    class CasusKalem : Kalem,IFotoMachine
    {
        public void TakePhoto()
        {
            Console.WriteLine("Casus Kalem ile Fotoğraf çekildi");
        }

        public override void write(string text)
        {
            Console.WriteLine($"{text} yazıldı...");
        }
    }
}
