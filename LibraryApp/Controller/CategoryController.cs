using LibraryApp.Data;
using LibraryApp.Services;
using LibraryApp.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryApp.Controller
{
    static class CategoryController
    {

        private static LibraryDbContext _context = new LibraryDbContext();
        private static CategoryService categoryService=new CategoryService(_context);

      

        public static void StartMenu()
        {
            while (true)
            {
                Console.WriteLine("\n-----KATEGORİ İŞLEMLERİ-----");
                Console.WriteLine("1- Kategori Listele");
                Console.WriteLine("2- Kategori Ekle");
                Console.WriteLine("3- Kategori Güncelle");
                Console.WriteLine("4- Kategori Sil");
                Console.WriteLine("0- Üst Menüye Dön");
                int secim = ReadClass.sayiAl("Seçiminiz: ");
                switch (secim)
                {
                    case 1: categoryService.ListCategories(); break;
                    case 2: categoryService.AddCategory(); break;
                    case 3: categoryService.UpdateCategory(); break;
                    case 4: categoryService.DeleteCategory(); break;
                    case 0: Console.WriteLine("Üst Menüye Geçiliyor"); return;
                    default: Console.WriteLine("Geçersiz Seçim"); break;

                }
            }
        }
    }
}
