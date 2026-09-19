using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Mp3PlayerBase : IMp3Player
    {
        public virtual void play()
        {
            Console.WriteLine("Mp3 Player oynatıyor");
        }

        public virtual void stop()
        {
            Console.WriteLine("Mp3 Player durduruldu");
        }
    }
}
