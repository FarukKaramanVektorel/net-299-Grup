using EntityIntro.Data;
using EntityIntro.Models;
using Microsoft.EntityFrameworkCore;

using var db = new OkulDbContext();

if (!db.Siniflar.Any())
{
    var sinif9A = new Sinif { Ad = "9-A" };
    var sinif10A = new Sinif { Ad = "10-A" };
    var sinif11A = new Sinif { Ad = "11-A" };
    var sinif12A = new Sinif { Ad = "12-A" };
    var sinif9B = new Sinif { Ad = "9-B" };
    var sinif10B = new Sinif { Ad = "10-B" };
    var sinif11B = new Sinif { Ad = "11-B" };
    var sinif12B = new Sinif { Ad = "12-B" };

    var matematik = new Ders { Ad = "Matematik", Kredi = 4 };
    var fizik = new Ders { Ad = "Fizik", Kredi = 2 };
    var edebiyat = new Ders { Ad = "Edebiyat", Kredi = 6 };
    var tarih = new Ders { Ad = "Tarih", Kredi = 3 };

    var sude = new Ogrenci
    {
        Ad = "Sude Nur",
        Soyad = "Sönmez",
        DogumTarihi = new DateTime(2005, 05, 15),
        Sinif = sinif12A,
        Dersler = {tarih,edebiyat,fizik,matematik}
    };

    var yigit = new Ogrenci
    {
        Ad = "Yiğit",
        Soyad = "Keser",
        DogumTarihi = new DateTime(2003, 05, 15),
        Sinif = sinif12A,
        Dersler = { tarih, edebiyat, fizik, matematik }
    };

    db.Ogrenci.AddRange(sude, yigit);
    db.SaveChanges();
    Console.WriteLine("Veriler eklendi...");
}

var ogrenciler=db.Ogrenci.Include(o=>o.Sinif).Include(o=>o.Dersler).ToList();
foreach (var o in ogrenciler)
{
    var dersadi = string.Join(", ", o.Dersler.Select(d => d.Ad));
    Console.WriteLine($"{o.Ad} {o.Soyad} - Sınıf: {o.Sinif.Ad}, Dersler: {dersadi}");
}
