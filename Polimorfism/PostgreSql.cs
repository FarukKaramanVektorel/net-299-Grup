using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfism
{
    class PostgreSql:DataBase
    {
        public override void Delete(string data)
        {
            Console.WriteLine($"PostgreSql {data} yı sildi");
        }

        public override void Get(string data)
        {
            Console.WriteLine($"PostgreSql {data} yı getirdi");
        }

        public override void Save(string data)
        {
            Console.WriteLine($"PostgreSql {data} yı kaydetti");
        }

        public override void Update(string data, string newData)
        {
            Console.WriteLine($"PostgreSql {data} yı {newData} ile değiştirdi");
        }
    }
}
