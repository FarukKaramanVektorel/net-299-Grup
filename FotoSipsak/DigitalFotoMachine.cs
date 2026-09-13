using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FotoSipsak
{
     class DigitalFotoMachine : FotoMachine
    {
        private double _capasity;

        public double Capasity
        {
            get { return _capasity; }
            set { if(value>0) _capasity = value; }
        }

        protected DigitalFotoMachine(string model, string marka, double capasity) : base(model, marka)
        {
            Capasity = capasity;
        }
        public void showCapasity()
        {
            Console.WriteLine($"Kalan Memory: {Capasity}");
        }

        public override void TakePhoto()
        {
            if (Capasity > 0.5)
            {
                base.TakePhoto();
                Capasity -= 0.5;
              
            }
            else
            {
                Console.WriteLine("Bellek Dolu");
            }
        }
    }
}
