using LibraryApp.Data;
using LibraryApp.Services;
using LibraryApp.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryApp.Controller
{
    static class AuthorController
    {
        private static LibraryDbContext _context = new LibraryDbContext();
        private static AuthorService authorService= new AuthorService(_context);
        

        public static void StartMenu()
        {
            while (true)
            {
                Console.WriteLine("\n-----YAZAR İŞLEMLERİ-----");
                Console.WriteLine("1- Yazarları Listele");
                Console.WriteLine("2- Yazar Ekle");
                Console.WriteLine("3- Yazar Güncelle");
                Console.WriteLine("4- Yazar Sil");
                Console.WriteLine("0- Üst Menüye Dön");
                int secim = ReadClass.sayiAl("Seçiminiz: ");
                switch (secim)
                {
                    case 1: authorService.ListAuthors(); break;
                    case 2: authorService.AddAuthor(); break;
                    case 3: authorService.UpdateAuthor(); break;
                    case 4: authorService.DeleteAuthors(); break;
                    case 0: Console.WriteLine("Üst Menüye Geçiliyor"); return;
                    default: Console.WriteLine("Geçersiz Seçim"); break;

                }
            }
        }
    }
}
