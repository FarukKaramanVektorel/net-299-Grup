using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavasOyunu
{
    class Wizard : KahramanBase
    {
        public Wizard(string name) : base(name, hiz:15, guc:150, saglik:40, ıyilesmeOrani:0.8)
        {
        }
    }
}
