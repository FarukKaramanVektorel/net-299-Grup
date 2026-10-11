using System;
using System.Collections.Generic;
using System.Text;

namespace EntityIntro.Models
{
    class Sinif
    {
        
        // SinifId - ID - sinifId primary key
        public int Id { get; set; }
        // Ad nvarchar(max)
        public string    Ad { get; set; }

        public List<Ogrenci> Ogrenciler { get; set; }
    }
}
