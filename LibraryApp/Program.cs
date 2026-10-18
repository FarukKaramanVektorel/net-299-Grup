using LibraryApp.Data;

using (var context=new LibraryDbContext())
{
    if (!context.Categories.Any())
    {
        context.Categories.AddRange(SeedData.categories);
        context.Authors.AddRange(SeedData.authors);
        context.Books.AddRange(SeedData.books);
        context.SaveChanges();
    }
}
