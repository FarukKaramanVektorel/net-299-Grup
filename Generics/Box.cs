using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Box
    {
        object[] kutu=new object[10];
        private int index = 0;
        public void Add(object player)
        {
            kutu[index] = player;
            Console.WriteLine($"{player} {index} indexine eklendi...");
            index++;
        }

        public void Listele()
        {
            for(int i = 0;i< kutu.Length; i++)
            {
                Console.WriteLine(kutu[i]);
                if (kutu[i] is Mp3PlayerBase mp3player)
                {
                    mp3player.play();
                }
            }
        }
    }
}
