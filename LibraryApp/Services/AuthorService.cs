using LibraryApp.Data;
using LibraryApp.Models;
using LibraryApp.Utils;

namespace LibraryApp.Services
{
    public class AuthorService
    {
        private readonly LibraryDbContext _context;
        public AuthorService(LibraryDbContext context)
        {
            _context = context;
        }

        public void ListAuthors()
        {
            var authors = _context.Authors.ToList();
            Console.WriteLine("\n------Yazar Listesi------");
            foreach (var a in authors)
            {
                Console.WriteLine($"ID: {a.Id} | {a.Name}");
            }
        }

        public void DeleteAuthors()
        {
            ListAuthors();
            Console.WriteLine();
            var author = _context.Authors.Find(ReadClass.sayiAl("Silmek İstediğiniz Yazarın ID'sini Giriniz."));
            if (author != null)
            {
                _context.Authors.Remove(author);
                _context.SaveChanges();
                Console.WriteLine($"{author.Name} başarıyla silindi...");
            }
            else
            {
                Console.WriteLine("Böyle bir yazar bulunamadı...");
            }



        }

        public void AddAuthor()
        {
            var author = new Author { Name = ReadClass.metinAl("Yazar adı giriniz...") };
            _context.Authors.Add(author);
            _context.SaveChanges();
            Console.WriteLine($"{author.Name} başarıyla eklendi...");
        }
        public void UpdateAuthor()
        {
            ListAuthors();
            Console.WriteLine();
            var author = _context.Authors.Find(ReadClass.sayiAl("Güncellemek İstediğiniz Yazar ID sini giriniz"));
            if (author != null)
            {

                author.Name = ReadClass.metinAl($"Yazır Adı: {author.Name}\nYeni Adı Giriniz: ");
                _context.SaveChanges();
                Console.WriteLine($"{author.Id} ID'li yazar güncellendi...");
            }
            else
            {
                Console.WriteLine("Böyle bir yazar yok...");
            }
        }
    }
}
