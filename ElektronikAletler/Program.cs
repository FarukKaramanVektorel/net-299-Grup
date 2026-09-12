using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElektronikAletler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Televizyon tv = new Televizyon("LG", 2.45, IsletimSistemi.Android, "45896", 140, 500, 50);

            tv.info();
            tv.close();
            tv.open();
            tv.open();
            tv.changeChannel(true);

            tv.info();

            

        }
    }
}
