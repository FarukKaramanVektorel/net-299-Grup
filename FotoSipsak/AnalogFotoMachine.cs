using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FotoSipsak
{
     class AnalogFotoMachine:FotoMachine
    {
		private int _poz;

        protected AnalogFotoMachine(string model, string marka, int poz) : base(model, marka)
        {
            Poz = poz;
        }

        public int Poz
		{
			get { return _poz; }
			set { if(value>0) _poz = value; }
		}
        public void showPoz()
        {
            Console.WriteLine($"Kalan Poz: {Poz}");
        }
        public override void TakePhoto()
        {
            if (Poz > 1)
            {
                base.TakePhoto();
                Poz -= 1;
               
            }
            else
            {
                Console.WriteLine("Poz bitti...");
            }
        }
    }
}
