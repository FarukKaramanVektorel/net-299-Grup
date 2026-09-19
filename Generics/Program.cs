using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //OtoTeyp oto=new OtoTeyp();
            //   oto.play();

            //   SmartPhone sp = new SmartPhone();
            //   sp.Call("4566666");
            //   sp.play();
            //   Box2<int> box = new Box2<int>();
            //   box.Add(45);
            //   box.Add(45);
            //   box.Add(45);
            //   box.Add(45);
            //   box.Add(45);
            //   box.Add(45);
            //   box.Add(45);
            //   box.List();
            //   Box2<string> names=new Box2<string>();
            //   names.Add("elif");
            //   names.Add("sevtap");
            //   names.Add("sude");
            //   names.Add("yiğit");
            //   names.List();
            //   Box2<Student> students = new Box2<Student>();
            //   students.Add(new Student());
            //   students.Add(new Student());
            //   students.Add(new Student());
            //   students.Add(new Student());
            //   students.Add(new Student());
            //   students.List();
            //   string[] namess = { "Ali", "Ayşe", "Kenan", "Elif" };

            //   Console.WriteLine(Array.IndexOf(namess,"Kemal"));
            Student s = new Student();

            Depo<Gida> gidaDepo = new Depo<Gida>();
            Gida gida = new Gida("Ülker Petibör",30);
            Gida gida1 = new Gida("Eti Cin",32);
            Gida gida2 = new Gida("Eti Negro",41);
            Gida gida3 = new Gida("Şölen Ozmo",29.99);
            Gida gida4 = new Gida("Salam",250.25);
            Gida gida5 = new Gida("Kavun",32.89);
            Giyim giyim1 = new Giyim("Atlet",119.99);
            Giyim giyim2 = new Giyim("T-Şort",499.99);
            Giyim giyim3 = new Giyim("Pantolon",999.99);
            Giyim giyim4 = new Giyim("Hırka",1499.99);
            gidaDepo.Add(gida);
            gidaDepo.Add(gida1);
            gidaDepo.Add(gida2);
            gidaDepo.Add(gida3);
            gidaDepo.Add(gida4);
            gidaDepo.Add(gida5);            
            gidaDepo.List();
            gidaDepo.Remove(gida3);
            gidaDepo.List();

            Depo<Giyim> giyimDepo = new Depo<Giyim>();
            giyimDepo.Add(giyim1);
            giyimDepo.Add(giyim2);
            giyimDepo.Add(giyim3);
            giyimDepo.Add(giyim4);

            giyimDepo.List();
            giyimDepo.Remove(giyim1);
            giyimDepo.List();
            Kirtasiye kitap = new Kirtasiye("Atlarıda vururlar", 500);

            Depo<Product>.MaliyetSoyle(giyim1);
            Depo<Product>.MaliyetSoyle(gida5);
            Depo<Product>.MaliyetSoyle(kitap);
            Console.ReadLine();
        }
    }
}
