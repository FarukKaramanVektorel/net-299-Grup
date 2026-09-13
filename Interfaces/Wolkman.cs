using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Interfaces
{
    class Wolkman : Mp3Player
    {
        public override void start(Mp3 parca)
        {
            Console.WriteLine($"{parca} Walkmande çalınıyor");
            Thread.Sleep(500);
        }

        public override void stop(Mp3 parca)
        {
            Console.WriteLine($"{parca} durduruldu");
        }
    }
}
