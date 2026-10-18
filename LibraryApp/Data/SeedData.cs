using LibraryApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryApp.Data
{
    public static class SeedData
    {
        public static List<Category> categories = new List<Category>
            {
                new Category { Name = "Yazılım" },
                new Category { Name = "Bilim" },
                new Category { Name = "Tarih" },
                new Category { Name = "Felsefe" },
                new Category { Name = "Kişisel Gelişim" }
            };

        public static List<Author> authors = new List<Author>
            {
                new Author { Name = "Robert C. Martin" },
                new Author { Name = "Martin Fowler" },
                new Author { Name = "Andrew Hunt" },
                new Author { Name = "Erich Gamma" },
                new Author { Name = "Steve McConnell" },
                new Author { Name = "Carl Sagan" },
                new Author { Name = "Stephen Hawking" },
                new Author { Name = "Richard Feynman" },
                new Author { Name = "Yuval Noah Harari" },
                new Author { Name = "İlber Ortaylı" },
                new Author { Name = "Halil İnalcık" },
                new Author { Name = "Platon" },
                new Author { Name = "Friedrich Nietzsche" },
                new Author { Name = "Marcus Aurelius" },
                new Author { Name = "Dale Carnegie" },
                new Author { Name = "James Clear" },
                new Author { Name = "Napoleon Hill" },
                new Author { Name = "Eric Freeman" },
                new Author { Name = "Jon Skeet" },
                new Author { Name = "Michael C. Feathers" }
            };

        public static List<Book> books = new List<Book>
            {
                // Yazılım
                new Book { Title = "Clean Code", PublishYear = 2008, IsRead = true, Author = authors[0], Category = categories[0] },
                new Book { Title = "The Clean Coder", PublishYear = 2011, IsRead = true, Author = authors[0], Category = categories[0] },
                new Book { Title = "Clean Architecture", PublishYear = 2017, IsRead = false, Author = authors[0], Category = categories[0] },
                new Book { Title = "Refactoring", PublishYear = 1999, IsRead = true, Author = authors[1], Category = categories[0] },
                new Book { Title = "UML Distilled", PublishYear = 1997, IsRead = false, Author = authors[1], Category = categories[0] },
                new Book { Title = "The Pragmatic Programmer", PublishYear = 1999, IsRead = true, Author = authors[2], Category = categories[0] },
                new Book { Title = "Design Patterns", PublishYear = 1994, IsRead = true, Author = authors[3], Category = categories[0] },
                new Book { Title = "Code Complete", PublishYear = 1993, IsRead = true, Author = authors[4], Category = categories[0] },
                new Book { Title = "Head First Design Patterns", PublishYear = 2004, IsRead = true, Author = authors[17], Category = categories[0] },
                new Book { Title = "C# in Depth", PublishYear = 2008, IsRead = true, Author = authors[18], Category = categories[0] },
                new Book { Title = "Working Effectively with Legacy Code", PublishYear = 2004, IsRead = false, Author = authors[19], Category = categories[0] },
                new Book { Title = "Clean Agile", PublishYear = 2019, IsRead = false, Author = authors[0], Category = categories[0] },
                
                // Bilim
                new Book { Title = "Cosmos", PublishYear = 1980, IsRead = true, Author = authors[5], Category = categories[1] },
                new Book { Title = "Pale Blue Dot", PublishYear = 1994, IsRead = true, Author = authors[5], Category = categories[1] },
                new Book { Title = "A Brief History of Time", PublishYear = 1988, IsRead = true, Author = authors[6], Category = categories[1] },
                new Book { Title = "The Universe in a Nutshell", PublishYear = 2001, IsRead = false, Author = authors[6], Category = categories[1] },
                new Book { Title = "Surely You're Joking, Mr. Feynman!", PublishYear = 1985, IsRead = true, Author = authors[7], Category = categories[1] },
                new Book { Title = "Six Easy Pieces", PublishYear = 1994, IsRead = true, Author = authors[7], Category = categories[1] },
                new Book { Title = "Contact", PublishYear = 1985, IsRead = false, Author = authors[5], Category = categories[1] },
                new Book { Title = "The Grand Design", PublishYear = 2010, IsRead = false, Author = authors[6], Category = categories[1] },

                // Tarih
                new Book { Title = "Sapiens", PublishYear = 2011, IsRead = true, Author = authors[8], Category = categories[2] },
                new Book { Title = "Homo Deus", PublishYear = 2015, IsRead = true, Author = authors[8], Category = categories[2] },
                new Book { Title = "21 Lessons for the 21st Century", PublishYear = 2018, IsRead = false, Author = authors[8], Category = categories[2] },
                new Book { Title = "Osmanlı'yı Yeniden Keşfetmek", PublishYear = 2006, IsRead = true, Author = authors[9], Category = categories[2] },
                new Book { Title = "Son İmparatorluk Osmanlı", PublishYear = 2006, IsRead = true, Author = authors[9], Category = categories[2] },
                new Book { Title = "Devlet-i Aliyye", PublishYear = 2009, IsRead = true, Author = authors[10], Category = categories[2] },
                new Book { Title = "Tarihin Akışında Osmanlı", PublishYear = 2007, IsRead = false, Author = authors[10], Category = categories[2] },
                new Book { Title = "The Silk Roads", PublishYear = 2015, IsRead = false, Author = authors[8], Category = categories[2] },

                // Felsefe
                new Book { Title = "Devlet (Politeia)", PublishYear = -375, IsRead = true, Author = authors[11], Category = categories[3] },
                new Book { Title = "Sokrates'in Savunması", PublishYear = -399, IsRead = true, Author = authors[11], Category = categories[3] },
                new Book { Title = "Böyle Buyurdu Zerdüşt", PublishYear = 1883, IsRead = true, Author = authors[12], Category = categories[3] },
                new Book { Title = "İyiliğin ve Kötülüğün Ötesinde", PublishYear = 1886, IsRead = false, Author = authors[12], Category = categories[3] },
                new Book { Title = "Düşünceler (Kendime Düşünceler)", PublishYear = 180, IsRead = true, Author = authors[13], Category = categories[3] },
                new Book { Title = "Putların Alacakaranlığı", PublishYear = 1889, IsRead = false, Author = authors[12], Category = categories[3] },
                new Book { Title = "Şölen (Symposion)", PublishYear = -385, IsRead = false, Author = authors[11], Category = categories[3] },
                new Book { Title = "Ecce Homo", PublishYear = 1908, IsRead = false, Author = authors[12], Category = categories[3] },

                // Kişisel Gelişim
                new Book { Title = "How to Win Friends and Influence People", PublishYear = 1936, IsRead = true, Author = authors[14], Category = categories[4] },
                new Book { Title = "Atomic Habits", PublishYear = 2018, IsRead = true, Author = authors[15], Category = categories[4] },
                new Book { Title = "Think and Grow Rich", PublishYear = 1937, IsRead = true, Author = authors[16], Category = categories[4] },
                new Book { Title = "Stop Worrying and Start Living", PublishYear = 1948, IsRead = false, Author = authors[14], Category = categories[4] },
                new Book { Title = "The 5 AM Club", PublishYear = 2018, IsRead = false, Author = authors[15], Category = categories[4] },
                new Book { Title = "The Magic of Thinking Big", PublishYear = 1959, IsRead = true, Author = authors[16], Category = categories[4] },
                new Book { Title = "The Leader In You", PublishYear = 1993, IsRead = false, Author = authors[14], Category = categories[4] },
                new Book { Title = "The Obstacle Is the Way", PublishYear = 2014, IsRead = true, Author = authors[13], Category = categories[4] },
                
                // 50'ye Tamamlayan Ek Kitaplar
                new Book { Title = "Clean Domain-Driven Design", PublishYear = 2021, IsRead = false, Author = authors[0], Category = categories[0] },
                new Book { Title = "Enterprise Integration Patterns", PublishYear = 2003, IsRead = false, Author = authors[1], Category = categories[0] },
                new Book { Title = "Pale Blue Dot Reflections", PublishYear = 1995, IsRead = false, Author = authors[5], Category = categories[1] },
                new Book { Title = "Avrupa'nın Zihninde Osmanlı", PublishYear = 2020, IsRead = false, Author = authors[9], Category = categories[2] },
                new Book { Title = "Phedo", PublishYear = -360, IsRead = false, Author = authors[11], Category = categories[3] },
                new Book { Title = "Master Your Habits", PublishYear = 2015, IsRead = true, Author = authors[15], Category = categories[4] },
                new Book { Title = "The Art of Public Speaking", PublishYear = 1915, IsRead = false, Author = authors[14], Category = categories[4] },
                new Book { Title = "The Design of Everyday Things", PublishYear = 1988, IsRead = true, Author = authors[4], Category = categories[0] }
            };

    }
}
