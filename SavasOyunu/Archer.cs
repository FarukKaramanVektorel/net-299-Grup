using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavasOyunu
{
    class Archer : KahramanBase
    {
        public Archer(string name) : base(name, hiz:20, guc:60, saglik:80, ıyilesmeOrani:0.6)
        {

        }
    }
}
