using LibraryApp.Data;
using LibraryApp.Services;
using LibraryApp.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryApp.Controller
{
    static class BookController
    {
        private static LibraryDbContext _context = new LibraryDbContext();
        private static BookService bookService= new BookService(_context);
        

        public static void StartMenu()
        {
            while (true)
            {
                Console.WriteLine("\n-----KİTAP İŞLEMLERİ-----");
                Console.WriteLine("1- Kitap Listele");
                Console.WriteLine("2- Kitap Ekle");
                Console.WriteLine("3- Kitap Güncelle");
                Console.WriteLine("4- Kitap Sil");
                Console.WriteLine("0- Üst Menüye Dön");
                int secim = ReadClass.sayiAl("Seçiminiz: ");
                switch (secim)
                {
                    case 1: bookService.ListBooks(); break;
                    case 2: bookService.AddBook(); break;
                    case 3: bookService.UpdateBook(); break;
                    case 4: bookService.DeleteBook(); break;
                    case 0: Console.WriteLine("Üst Menüye Geçiliyor"); return;
                    default: Console.WriteLine("Geçersiz Seçim"); break;

                }
            }
        }
    }
}
