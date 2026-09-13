using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Mp3
    {
        private string _name;
        private string _sanatci;
        private double _sure;

        public double Sure
        {
            get { return _sure; }
            set { 
            if(value > 0)
                {
                    _sure = value;
                }
                else
                {
                    _sure = 1;
                    Console.WriteLine("Bizim gezegenimizde - bir varlık yoktur");
                }
            }
        }


        public string Sanatci
        {
            get { return _sanatci; }
            set { _sanatci = value; }
        }


        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }


        public Mp3(string name, string sanatci, double sure)
        {
            Name = name;
            Sanatci = sanatci;
            Sure = sure;
        }

        public bool sureHesapla(bool type)
        {
            return 45>0;
        }

        public int sureHesapla()
        {
            return 45 ;
        }
        public override string ToString()
        {
            return $"Sanatçı: {Sanatci} Eser: {Name} Saniye: {Sure}";
        }
    }
}
