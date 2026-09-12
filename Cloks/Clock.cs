using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cloks
{
    internal abstract class Clock
    {
        public int Second { get; set; }
        public int Minute { get; set; }
        public int Hour { get; set; }

        public Clock(int second, int minute, int hour)
        {
            Second = second;
            Minute = minute;
            Hour = hour;
        }

        public void ilerle(int second)
        {
            for (int i = 0; i < second; i++)
            {
                ilerle();
            }
        }
        public  void ilerle()
        {
            if (Second < 60)
            {
                Second++;
            }
            else
            {
                Second = 1;
                minutePlus();

            }
        }

        private void minutePlus()
        {
            if (Minute < 60)
            {
                Minute++;
            }
            else
            {
                Minute = 1;
                hourPlus();

            }
        }

        protected virtual void hourPlus()
        {
            if (Hour < 24)
            {
                Hour++;
            }
            else
            {
                Hour = 0;
            }
        }

        public abstract void saatGoster();
    }
}
