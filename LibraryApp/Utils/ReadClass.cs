using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;

namespace LibraryApp.Utils
{
    public static class ReadClass
    {
        public static int sayiAl(string message)
        {
            Console.WriteLine(message);
            int.TryParse(Console.ReadLine(), out int sayi);
            return sayi;
        }

        public static string metinAl(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine()??"";
        }
        public static bool boolAl(string message)
        {
            Console.WriteLine(message);
            bool.TryParse(Console.ReadLine(), out bool status);
            return status;
        }



    }
}
