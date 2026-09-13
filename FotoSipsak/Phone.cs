using System;

namespace FotoSipsak
{
    internal class Phone
    {
        public virtual void call(string number)
        {
            Console.WriteLine($"{number} aranıyor...");
        }
    }
}