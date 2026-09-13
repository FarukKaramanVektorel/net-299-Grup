using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FotoSipsak
{
    class SmartPhone : Phone, IFotoMachine
    {
        public void TakePhoto()
        {
            Console.WriteLine("Akıllı Telefon ile fotoğraf çekildi");
        }
    }


}
