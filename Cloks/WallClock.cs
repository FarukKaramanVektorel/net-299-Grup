using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Cloks
{
    internal class WallClock : Clock
    {
        public WallClock(int second, int minute, int hour) : base(second, minute, hour)
        {
        }

        public override void saatGoster()
        {
            Console.WriteLine($"Duvar Saati: {Hour}:{Minute}:{Second}");
        }
        
        protected override void hourPlus()
        {
            if (Hour < 12)
            {
                Hour++;
            }
            else
            {
                Hour = 1;
            }
        }
    }
}
