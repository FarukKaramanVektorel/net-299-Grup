using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Interfaces
{
    sealed class Teyp : Mp3Player
    {
        public Battery Pil { get; set; }
        public override void start(Mp3 parca)
        {
            int saniye = (int)(parca.Sure * 60)/100;
            for (int i = 0; i < saniye; i++)
            {
                Console.WriteLine($"Çalınan Parça: {parca} Kalan süre: {saniye-i}");
                Thread.Sleep(500);
            }
        }

        public override void stop(Mp3 parca)
        {
            Console.WriteLine($"{parca} durduruldu");
           
        }

        public override sealed void bisey()
        {
            Console.WriteLine("Override edilen metod");
        }
    }
}
