using System;
using System.Collections.Generic;
using System.Text;

namespace EntityIntro.Models
{
    class Ders
    {
        public int Id { get; set; }
        public string  Ad { get; set; }
        public int Kredi { get; set; }

        public List<Ogrenci> Ogrenciler { get; set; }
    }
}
