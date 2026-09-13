using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfism
{
    class FileSystem : IDataBase
    {


        public void Read(string path)
        {
            Console.WriteLine($"{path} yolundaki dosya okundu");
        }

        public  void Delete(string data)
        {
            Console.WriteLine($"File sistem {data} yı sildi");
        }

        public  void Get(string data)
        {
            Console.WriteLine($"File sistem {data} yı getirdi");
        }

        public  void Save(string data)
        {
            Console.WriteLine($"File sistem {data} yı kaydetti");
        }

        public  void Update(string data, string newData)
        {
            Console.WriteLine($"File sistem {data} yı {newData} ile değiştirdi");
        }
    }
}
