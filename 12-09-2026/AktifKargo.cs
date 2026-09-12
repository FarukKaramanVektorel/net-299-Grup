using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_09_2026
{
    internal class AktifKargo
    {
        public static Kargo[] Kargolar = new Kargo[0];
        public static int Index = 0;


        public static void kargoEkle(Kargo kargo)
        {
            Array.Resize(ref Kargolar, Kargolar.Length + 1);
            Kargolar[Index] = kargo;
            Index++;
        }

        public static Kargo kargoAra(string code)
        {
            Kargo result = null;
            foreach(Kargo kargo in Kargolar)
            {
                if(kargo.Code == code)
                {
                    result = kargo; break;
                }
            }
            return result;
        }
    }
}
