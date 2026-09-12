using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    class UretimPersoneli:Person
    {
        public int UretimAdedi { get; set; }
        public UretimPersoneli(string name, string lastName, DateTime birthDay, string meslek, int uretimAdedi) : base(name, lastName, birthDay, meslek)
        {
            UretimAdedi = uretimAdedi;
              
        }

        public override double MaasHesapla()
        {
            return (UretimAdedi * 5) + ASGARI_UCRET;
        }
    }
}
