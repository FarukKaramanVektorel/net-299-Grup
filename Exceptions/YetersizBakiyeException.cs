using System;
using System.Collections.Generic;
using System.Text;

namespace Exceptions
{
    class YetersizBakiyeException:Exception
    {
        public YetersizBakiyeException(string message,double eksiktutar):base(message) 
        {
            Eksiktutar = eksiktutar;
        }

        public double Eksiktutar { get;  }



    }
}
