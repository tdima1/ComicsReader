using ComicsReader.Models.DbContexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComicsReader.Models
{
   public class ComicBookRepository : IComicBookRepository
   {
      private readonly AppDbContext _comicBooksDbContext;
      public ComicBookRepository(AppDbContext comicBooksDbContext)
      {
         _comicBooksDbContext = comicBooksDbContext;
      }

      public IEnumerable<ComicBook> AllComicBooks => _comicBooksDbContext.ComicBooks.Include(c => c.Category);

      public IEnumerable<ComicBook> PopularComicBooks => _comicBooksDbContext.ComicBooks.Include(c => c.Category).Where(c => c.IsPopular);

      public ComicBook GetComicBookById(int id)
      {
         return _comicBooksDbContext.ComicBooks.FirstOrDefault(c => c.Id == id);
      }
   }
}
