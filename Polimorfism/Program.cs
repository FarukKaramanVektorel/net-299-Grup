using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MongoDb db = new MongoDb();
            PostgreSql psql = new PostgreSql();
            Oracle oracle= new Oracle();
            MsSql mssql=new MsSql();
            FileSystem fs = new FileSystem();
            DataBaseManeger dataBaseManeger = new DataBaseManeger(oracle);
            dataBaseManeger.Connect();
            dataBaseManeger.Save("Hava güzel");
            dataBaseManeger.Update("Bugün Hava Güzel", "Hava güzel");
            dataBaseManeger.Get("Bugün Hava güzel");
            dataBaseManeger.Get("Bugün Hava güzel","C:\\Windows\\Users\\test.txt");
            dataBaseManeger.Delete("Bugün Hava Güzel");
            dataBaseManeger.Disconnect();

        }
    }
}
