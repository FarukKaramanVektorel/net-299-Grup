using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavasOyunu
{
    class Ahtapot : CanavarBase
    {
        public Ahtapot(string name) : base(name, guc:80, savunma:15, saglik:40)
        {
        }
    }
}
