using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfism
{
    class MongoDb : DataBase
    {
        public override void Delete(string data)
        {
            Console.WriteLine($"MongoDB {data} yı sildi");
        }

        public override void Get(string data)
        {
            Console.WriteLine($"MongoDB {data} yı getirdi");
        }

        public override void Save(string data)
        {
            Console.WriteLine($"MongoDB {data} yı kaydetti");
        }

        public override void Update(string data, string newData)
        {
            Console.WriteLine($"MongoDB {data} yı {newData} ile değiştirdi");
        }
    }
}
