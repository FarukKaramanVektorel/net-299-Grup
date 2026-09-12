using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElektronikAletler
{
    internal class ElektronikAlet
    {
        public string Marka { get; set; }
        public double Power { get; set; }
        public bool IsRun { get; set; }
        public IsletimSistemi IsletimSistemi { get; set; }

        public ElektronikAlet(string marka, double power, IsletimSistemi isletimSistemi)
        {
            Marka = marka;
            Power = power;
            IsRun = false;
            IsletimSistemi = isletimSistemi;
        }

        public void open()
        {
            if (!IsRun)
            {
                IsRun = true;
            }
            else
            {
                Console.WriteLine("Zaten açıkya, neyi açayım?");
            }
        }

        public void close()
        {
            if (IsRun)
            {
                IsRun = false;
            }
            else
            {
                Console.WriteLine("Kapalı ya amcaoğlu????");
            }
        }
    }
}
