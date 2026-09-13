using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfism
{
    class DataBaseManeger
    {
       

        public IDataBase db { get; set; }

        public DataBaseManeger(IDataBase mongodb)
        {
            db = mongodb;
        }


        public void Connect()
        {
            Console.WriteLine($"{db} de Connection işlemi yapıldı");
        }
        public void Save(string data)
        {
            db.Save(data);
        }
        public void Update(string newData,string data)
        {
            db.Update(data,newData);
        }
        public void Delete(string data)
        {
            db.Delete(data);
        }
        public void Get(string data)
        {
            db.Get(data);
        }

        public void Get(string data,string path)
        {
            if (db is FileSystem fs)
            {
                fs.Get(path);
                db.Get(data);
            }
            else
            {
                Console.WriteLine("Database sistemlerinde path yok ya hani...");
            }

           
        }
        public void Disconnect() { 
            Console.WriteLine($"{db} de Disonnect işlemi yapıldı"); 
        }
    }
}
