using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfism
{
    interface IDataBase
    {
        //CRUD 
        void Save(string data);
        void Update(string data,string newData);
        void Delete(string data);
        void Get(string data);
    }
}
