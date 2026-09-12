using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_09_2026
{
    internal class Kargo
    {
        public string TeslimEden { get; set; }
        public string  Teslimalan { get; set; }
        public Status Status { get; set; }
        public string Code { get; set; }

        public Kargo(string teslimEden, string teslimalan)
        {
            TeslimEden = teslimEden;
            Teslimalan = teslimalan;
           
        }
    }
}
