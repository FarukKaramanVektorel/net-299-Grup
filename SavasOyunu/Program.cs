using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavasOyunu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // KahramanBase
            // Hız, Güç, İyileşme Oranı, Sağlık
            // Okçu
            // Kılıç Ustası
            // Büyücü
            // CanavarBase
            // Üç Başlı Yılan
            // Ejderha
            // Ahtapot
            // Kahraman Canavara Saldıracak 
            Archer okcu = new Archer("Ulubatlı Hasan");
            Ejderha ejder = new Ejderha("Ejder");

            okcu.Saldir(ejder);
            ejder.Saldir(okcu);
            okcu.Saldir(ejder);
            ejder.Saldir(okcu);
            okcu.Saldir(ejder);
            ejder.Saldir(okcu);
            okcu.Saldir(ejder);
            ejder.Saldir(okcu);
            okcu.Saldir(ejder);
            ejder.Saldir(okcu);
            okcu.Saldir(ejder);
            ejder.Saldir(okcu);
        }
    }
}
