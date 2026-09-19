using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class OtoTeyp : Mp3PlayerBase
    {
        public override void play()
        {
            Console.WriteLine("Oto Teyp oynatıyor");
        }

        public override void stop()
        {
            Console.WriteLine("Oto Teyp durduruldu");
        }

    }
}
