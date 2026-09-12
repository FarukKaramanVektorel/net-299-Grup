using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElektronikAletler
{
    internal abstract class SmartPhone : Phone
    {
        public SmartPhone(string marka, double power, IsletimSistemi isletimSistemi) : base(marka, power, isletimSistemi)
        {
        }

       
    }
}
