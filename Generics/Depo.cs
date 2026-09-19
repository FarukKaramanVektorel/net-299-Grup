using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Depo<T> where T : Product
    {
        public Product[] urunler = new Product[1];



        public void Add(T product)
        {
            urunler[urunler.Length - 1] = product;
            Array.Resize(ref urunler, urunler.Length + 1);
           

        }

        public void Remove(T product)
        {
            int index = Array.IndexOf(urunler, product);
            if (index != -1)
            {
                // 1,2,4,5,5
                for (int i = index; i < urunler.Length; i++)
                {
                    if (i < urunler.Length - 1)
                    {
                        urunler[i] = urunler[i + 1];
                    }
                    else
                    {
                        urunler[i] = null;
                    }

                }
                Array.Resize(ref urunler, urunler.Length - 1);
                Console.WriteLine($"{product} silindi...");
            }
            else
            {
                Console.WriteLine($"Araduığınız {product} depoda yok");
            }

        }

        public void List()
        {
            Remove(null);
            for (int i = 0; i < urunler.Length; i++)
            {
                Console.WriteLine($"{i}/{urunler.Length-1}-{urunler[i]}");
            }
        }

        public static void MaliyetSoyle(T product)
        {
            product.Maliyet();
        }



    }
}
