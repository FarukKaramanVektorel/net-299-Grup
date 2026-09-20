using System;
using System.Collections.Generic;
using System.Text;

namespace Collections2
{
    class Fruit
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
        public Fruit(string code, string name, double price, int stock)
        {
            Code = code;
            Name = name;
            Price = price;
            Stock = stock;
        }

        public double buyFruit(int kg)
        {
            if (Stock >= kg)
            {
                Stock -= kg;
                return kg * Price;
            }
            Console.WriteLine($"Maalesef {Name} meyvesinden kalmadı...");
            return 0;

        }


    }



}
