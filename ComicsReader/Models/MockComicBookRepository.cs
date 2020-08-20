using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComicsReader.Models
{
   public class MockComicBookRepository : IComicBookRepository
   {
      private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();

      public IEnumerable<ComicBook> AllComicBooks => new List<ComicBook> {
         new ComicBook{Id=1, Title="Title1", NumberOfPages= 50, Category = _categoryRepository.GetCategoryById(1), Price=25, IsPopular = false},
         new ComicBook{Id=2, Title="Title2", NumberOfPages= 50, Category = _categoryRepository.GetCategoryById(1), Price=25, IsPopular = false},
         new ComicBook{Id=3, Title="Title3", NumberOfPages= 50, Category = _categoryRepository.GetCategoryById(1), Price=25, IsPopular = true},
         new ComicBook{Id=4, Title="Title4", NumberOfPages= 50, Category = _categoryRepository.GetCategoryById(1), Price=25, IsPopular = false},
         new ComicBook{Id=5, Title="Title5", NumberOfPages= 50, Category = _categoryRepository.GetCategoryById(1), Price=25, IsPopular = true},
      };

      public IEnumerable<ComicBook> PopularComicBooks => AllComicBooks.Where(c => c.IsPopular).ToList();

      public ComicBook GetComicBookById(int id)
      {
         return AllComicBooks.First(c => c.Id == id);
      }
   }
}
