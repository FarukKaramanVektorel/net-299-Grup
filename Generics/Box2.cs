using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Box2<T>
    {
        public T[] arr = new T[10];
        public int index = 0;


        public void Add(T obj)
        {
            arr[index++] = obj;
        }

        public void List()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

    }
}
