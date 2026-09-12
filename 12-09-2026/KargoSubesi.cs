using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_09_2026
{
    internal class KargoSubesi
    {
        public string Name { get; set; }
        public Ilce ilce { get; set; }        

        public string Phone { get; set; }       

        public KargoSubesi(string name, Ilce ilce,  string phone)
        {
            Name = name;
            this.ilce = ilce;            
            Phone = phone;            
        }

        public string teslimAl(Kargo kargo)
        {
            kargo.Status = Status.SubeyeTeslimEdildi;
            string code= getCode();
            kargo.Code= code;
            KargoEkle(kargo);
            return code;
        }

        public void islemYap(Kargo kargo, Status status)
        {
            kargo.Status = status;
        }

        private void KargoEkle(Kargo kargo)
        {
            AktifKargo.kargoEkle(kargo);
        }

        public Kargo kargoAra(string code)
        {
            Kargo kargo=AktifKargo.kargoAra(code);
            return kargo!=null?kargo:null;
        }

        private string getCode()
        {
            Random rnd = new Random();
            string harfler = "ABCDEFGHIJKLMNOPRSTUVYZXQW";
            int index = 0;
            string code = "";
            for (int i = 0; i < harfler.Length; i++)
            {
                int randomIndex = rnd.Next(0, harfler.Length );
                if (index < 16)
                {
                    if (index % 4 == 0)
                    {
                        code += " ";
                    }
                    code += harfler[randomIndex];
                    index++;
                }
                else
                {
                    break;
                }
               

            }
            Console.WriteLine("Üretilen Code: "+code);
            return code;
        }


    }
}
