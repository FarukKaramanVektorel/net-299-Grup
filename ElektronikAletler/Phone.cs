using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElektronikAletler
{
    internal abstract class Phone : ElektronikAlet
    {
        public Phone(string marka, double power, IsletimSistemi isletimSistemi) : base(marka, power, isletimSistemi)
        {
        }

        public abstract void call(string number);

    }
}
