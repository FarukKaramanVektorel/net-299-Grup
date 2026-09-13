using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FotoSipsak
{
	class Fotografher
	{
		private string _name;

		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}

        public Fotografher(string name)
        {
            Name = name;
        }

        public void TakePhoto(IFotoMachine machine)
		{
			if (machine is CasusKalem ck)
			{
				ck.write("Birşeyler...");
				ck.TakePhoto();
			}
			else if (machine is SmartPhone sp)
			{
				sp.call("5425424242");
				sp.TakePhoto();
			}
			else
			{
				machine.TakePhoto();
				if(machine is AnalogFotoMachine afm)
				{
					afm.showPoz();
				}
				else if(machine is DigitalFotoMachine dfm)
				{
					dfm.showCapasity();
				}
			}

		}
	}
}
