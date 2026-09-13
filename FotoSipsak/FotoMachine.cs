using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FotoSipsak
{
    abstract class FotoMachine : IFotoMachine
    {
        private string _marka;
        private string _model;

        protected FotoMachine(string model, string marka)
        {
            Model = model;
            Marka = marka;
        }

        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }


        public string Marka
        {
            get { return _marka; }
            set { _marka = value; }
        }

        public virtual void TakePhoto()
        {
            Console.WriteLine($"{Marka} Marka Foroğraf Makinası ile Fotoğraf çekildi");
        }
    }
}
