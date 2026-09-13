using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FotoSipsak
{
    internal class Program
    {
        static void Main(string[] args)
        {
           CasusKalem ck=new CasusKalem();
            SmartPhone sp=new SmartPhone();
            NikkonAnalog na = new NikkonAnalog("456", "Nikkon", 3);
            NikkonDigital nd = new NikkonDigital("EOS45", "Nikkon", 3.5);

            Fotografher foto = new Fotografher("Foto Cafer");

            foto.TakePhoto(ck);
            foto.TakePhoto(sp);
            foto.TakePhoto(nd);
            foto.TakePhoto(nd);
            foto.TakePhoto(nd);
            foto.TakePhoto(nd);
            foto.TakePhoto(nd);
            foto.TakePhoto(nd);
            foto.TakePhoto(nd);
            foto.TakePhoto(nd);
            foto.TakePhoto(nd);
            foto.TakePhoto(nd);
            foto.TakePhoto(nd);
            foto.TakePhoto(nd);
            foto.TakePhoto(na);
            foto.TakePhoto(na);
            foto.TakePhoto(na);
            foto.TakePhoto(na);

        }
    }
}
