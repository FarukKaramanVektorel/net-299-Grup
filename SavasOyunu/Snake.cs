using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavasOyunu
{
    class Snake : CanavarBase
    {
        public Snake(string name) : base(name, guc:50, savunma:10, saglik:150)
        {
        }
    }
}
