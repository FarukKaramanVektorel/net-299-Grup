using LibraryApp.Data;
using LibraryApp.Models;
using LibraryApp.Utils;

namespace LibraryApp.Services
{
    public class AuthorService
    {        private readonly LibraryDbContext _context;
        public AuthorService(LibraryDbContext context)
        {
            _context = context;
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
