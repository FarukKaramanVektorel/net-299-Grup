using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    abstract class Mp3Player : IMp3Player
    {
        public abstract void start(Mp3 parca);
        public abstract void stop(Mp3 parca);

        public virtual void bisey()
        {
            Console.WriteLine("virtual metod");
        }
    }
}
