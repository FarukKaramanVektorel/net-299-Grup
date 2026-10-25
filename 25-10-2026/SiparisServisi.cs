using System;
using System.Collections.Generic;
using System.Text;

namespace _25_10_2026
{
    class SiparisServisi
    {
        //tight coupling / sıkı bağlantı
        private readonly IVeriTabani _veriTabani;

        public SiparisServisi(IVeriTabani veriTabani)
        {
            _veriTabani = veriTabani;
        }

        public void SiparisOlustur(string data)
        {
            _veriTabani.Kaydet(data);
        }
    }
}
