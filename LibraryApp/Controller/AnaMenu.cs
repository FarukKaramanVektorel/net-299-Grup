using LibraryApp.Data;
using LibraryApp.Services;
using LibraryApp.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryApp.Controller
{
    public static class AnaMenu
    {
        
        public static void StartMenu()
        {
            using (var context = new LibraryDbContext())
            {
                if (!context.Categories.Any())
                {
                    context.Categories.AddRange(SeedData.categories);
                    context.Authors.AddRange(SeedData.authors);
                    context.Books.AddRange(SeedData.books);
                    context.SaveChanges();
                }
               
                while (true)
                {
                    Console.WriteLine("\n=====KÜTÜPHANE YÖNETİM SİSTEMİ=====");
                    Console.WriteLine("1- Kitap İşlemleri");
                    Console.WriteLine("2- Yazar İşlemleri");
                    Console.WriteLine("3- Kategori İşlemleri");
                    Console.WriteLine("0- Çıkış");
                    int secim = ReadClass.sayiAl("Seçiminiz: ");
                    switch (secim)
                    {
                        case 1: BookController.StartMenu(); break;
                        case 2: AuthorController.StartMenu(); break;
                        case 3: CategoryController.StartMenu(); break;
                        case 0: Console.WriteLine("Çıkış yapılıyor"); return;
                        default: Console.WriteLine("Geçersiz Seçim"); break;

                    }
                }
            }
        }
    }
}
