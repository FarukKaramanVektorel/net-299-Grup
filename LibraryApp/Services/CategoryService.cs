using LibraryApp.Data;
using LibraryApp.Models;
using LibraryApp.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryApp.Services
{
    class CategoryService
    {
        private readonly LibraryDbContext _context;

        public CategoryService(LibraryDbContext context)
        {
            _context = context;
        }

        public void AddCategory()
        {
            var category = new Category { Name = ReadClass.metinAl("Kategori adı giriniz...") };
            _context.Categories.Add(category);
            _context.SaveChanges();
            Console.WriteLine($"{category.Name} başarıyla eklendi...");
        }

        public void UpdateCategory()
        {
            ListCategories();
            Console.WriteLine();
            var category = _context.Categories.Find(ReadClass.sayiAl("Güncellemek İstediğiniz Kategori ID sini giriniz"));
            if (category != null)
            {

                category.Name = ReadClass.metinAl($"Kategori Adı: {category.Name}\nYeni Adı Giriniz: ");
                _context.SaveChanges();
                Console.WriteLine($"{category.Id} ID'li kategori güncellendi...");
            }
            else
            {
                Console.WriteLine("Böyle bir yazar yok...");
            }
        }

        public void ListCategories()
        {
            var categories = _context.Categories.ToList();
            Console.WriteLine("\n------Kategori Listesi------");
            foreach (var a in categories)
            {
                Console.WriteLine($"ID: {a.Id} | {a.Name}");
            }
        }

        public void DeleteCategory()
        {
            ListCategories();
            Console.WriteLine();
            var category = _context.Categories.Find(ReadClass.sayiAl("Silmek İstediğiniz Kategori ID'sini Giriniz."));
            if (category != null)
            {
                _context.Categories.Remove(category);
                _context.SaveChanges();
                Console.WriteLine($"{category.Name} başarıyla silindi...");
            }
            else
            {
                Console.WriteLine("Böyle bir kategori bulunamadı...");
            }



        }


    }
}
