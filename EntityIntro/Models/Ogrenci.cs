using System;
using System.Collections.Generic;
using System.Text;

namespace EntityIntro.Models
{
    class Ogrenci
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }

        public DateTime DogumTarihi { get; set; }
        public int SinifId { get; set; }

        public List<Ders> Dersler { get; set; }
    }
}
