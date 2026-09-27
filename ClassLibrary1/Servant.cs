using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class Servant : Person
    {
        public Servant(string name, double salary) : base(name, salary)
        {
        }

        public override double maasHesapla2()
        {
            return Salary*0.9;
        }
    }
}
