using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_09_2026
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Il ankara = new Il(6, "Ankara");
            Ilce cankaya = new Ilce(1, ankara, "Çankaya");
            KargoSubesi ks = new KargoSubesi("Kızılay Şubesi", cankaya, "3123121212");
            Kargo paket = new Kargo("Elif Alemdar", "Banko Memuru");
            string code=ks.teslimAl(paket);
            Console.WriteLine(EnumExtentions.GetDescription(paket.Status));
            ks.islemYap(paket,Status.SubedenAktarmaMerkezine);
            Kargo durum = ks.kargoAra(code);
            Console.WriteLine(EnumExtentions.GetDescription(paket.Status));
            ks.islemYap(paket, Status.IlDisiAktarma);
            Console.WriteLine(EnumExtentions.GetDescription(durum.Status));
            durum = ks.kargoAra(code);
            ks.islemYap(paket, Status.AktarmaMerkezindenSubeye);            
            durum = ks.kargoAra(code);
            Console.WriteLine(EnumExtentions.GetDescription(durum.Status));
            Console.ReadLine();
        }

       
    }
}
