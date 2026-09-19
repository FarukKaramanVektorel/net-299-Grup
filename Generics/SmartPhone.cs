using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class SmartPhone : PhoneBase,IMp3Player
    {
        public override void Call(string phoneNumber)
        {
            Console.WriteLine($"{phoneNumber} aranıyor...");
        }

        public  void play()
        {
            Console.WriteLine("Mp3 Player Akıllı Telefonda oynatıyor");
        }

        public  void stop()
        {
            Console.WriteLine("Akıllı telefonda Mp3 Player durduruldu");
        }
    }
}
