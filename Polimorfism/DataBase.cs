using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfism
{
    abstract class DataBase : IDataBase
    {
        public abstract void Delete(string data);
        public abstract void Get(string data);
        public abstract void Save(string data);
        public abstract void Update(string data, string newData);
    }
}
