using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavasOyunu
{
    class Swordman : KahramanBase
    {
        public Swordman(string name) : base(name, hiz:10, guc:120, saglik:90, ıyilesmeOrani:0.5)
        {
        }
    }
}
