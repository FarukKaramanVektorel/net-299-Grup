using LibraryApp.Data;
using LibraryApp.Models;
using LibraryApp.Utils;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryApp.Services
{
    class BookService
    {
        private readonly LibraryDbContext _context;

        public BookService(LibraryDbContext context)
        {
            _context = context;
        }

        public void AddBook()
        {
            var book = new Book
            {
                Title = ReadClass.metinAl("Kitap Adını Giriniz"),
                PublishYear = ReadClass.sayiAl("Kitap Basım yılını giriniz"),
                IsRead = false,
                AuthorId = ReadClass.sayiAl("Yazar ID'sini giriniz"),
                CategoryId = ReadClass.sayiAl("Kategori ID'sini giriniz"),

            };

            _context.Books.Add(book);
            _context.SaveChanges();
            Console.WriteLine($"{book.Title} başarıyla eklendi...");
        }

        public void UpdateBook()
        {
            ListBooks();
            Console.WriteLine();
            var book = _context.Books.Find(ReadClass.sayiAl("Güncellemek İstediğiniz Kitap ID sini giriniz"));
            if (book != null)
            {

                book.Title = ReadClass.metinAl($"Kitap Adı: {book.Title}\nYeni Adı Giriniz: ");
                book.PublishYear = ReadClass.sayiAl($"Mevcut Yıl: {book.PublishYear}\nYeni yılı giriniz: ");
                book.AuthorId = ReadClass.sayiAl($"Mevcut Yazar ID: {book.AuthorId}\nYeni Yazar ID giriniz: ");
                book.CategoryId = ReadClass.sayiAl($"Mevcut Kategori ID: {book.PublishYear}\nYeni Kategori I giriniz: ");               
                _context.SaveChanges();
                Console.WriteLine($"{book.Id} ID'li kitap güncellendi...");
            }
            else
            {
                Console.WriteLine("Böyle bir yazar yok...");
            }
        }

        public void ListBooks()
        {
            var books = _context.Books.Include(b=>b.Category).Include(b=>b.Author).ToList();
            Console.WriteLine("\n------Kitap Listesi------");
            foreach (var a in books)
            {
                var durum = a.IsRead ? "Okundu" : "Okunmadı";
                Console.WriteLine($"ID: {a.Id} | {a.Category.Name} {a.Title} - {a.Author.Name} - {durum}");
            }
        }

        public void DeleteBook()
        {
            ListBooks();
            Console.WriteLine();
            var book = _context.Books.Find(ReadClass.sayiAl("Silmek İstediğiniz Kitap ID'sini Giriniz."));
            if (book != null)
            {
                _context.Books.Remove(book);
                _context.SaveChanges();
                Console.WriteLine($"{book.Title} başarıyla silindi...");
            }
            else
            {
                Console.WriteLine("Böyle bir Kitap bulunamadı...");
            }



        }


    }
}
