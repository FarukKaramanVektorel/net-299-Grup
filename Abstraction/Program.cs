using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Yonetici mudur = new Yonetici("Abdullah", "Keskin", new DateTime(1985, 5, 3), "Yönetici", 5, new string[] { "Pazarlama", "Üretim", "Muhasebe" });
            UretimPersoneli up = new UretimPersoneli("Elif", "Eylül", new DateTime(1995, 4, 28), "Son Ütücü", 2850);
            UretimPersoneli up1 = new UretimPersoneli("Elif", "Eylül", new DateTime(1995, 4, 28), "Son Ütücü", 2850);
            UretimPersoneli up2 = new UretimPersoneli("Kemal", "Eylül", new DateTime(1994, 4, 28), "Makinacı", 2750);
            UretimPersoneli up3 = new UretimPersoneli("Elif", "Eylül", new DateTime(1993, 7, 14), "Makinacı", 2650);
            UretimPersoneli up4 = new UretimPersoneli("Elif", "Eylül", new DateTime(1991, 8, 22), "Son Ütücü", 2950);
            UretimPersoneli up5 = new UretimPersoneli("Elif", "Eylül", new DateTime(1997, 3, 15), "Makinacı", 3250);
            UretimPersoneli up6 = new UretimPersoneli("Elif", "Eylül", new DateTime(1985, 1, 1), "Son Ütücü", 3150);

            PazarlamaPersoneli pp = new PazarlamaPersoneli(595000, "Erhan", "Ufak", new DateTime(1998, 9, 30), "Pazarlama");
            Console.WriteLine($"Çalışan Personel Sayısı: {Person.CalisanSayisi}");
            Console.WriteLine($"{mudur}, Maaş: {mudur.MaasHesapla():C2}");
            Console.WriteLine($"{up}, Maaş: {up.MaasHesapla():C2}");
            Console.WriteLine($"{up2}, Maaş: {up2.MaasHesapla():C2}");
            Console.WriteLine($"{up3}, Maaş: {up3.MaasHesapla():C2}");
            Console.WriteLine($"{up4}, Maaş: {up4.MaasHesapla():C2}");
            Console.WriteLine($"{up5}, Maaş: {up5.MaasHesapla():C2}");
            Console.WriteLine($"{up6}, Maaş: {up6.MaasHesapla():C2}");
            Console.WriteLine($"{pp}, Maaş: {pp.MaasHesapla():C2}");
            UretimPersoneli up9 = up;
            if (up.Equals(up1))
            {
                Console.WriteLine("Eşit");
            }
            else
            {
                Console.WriteLine("Eşit değil");
            }
        }
    }
}
