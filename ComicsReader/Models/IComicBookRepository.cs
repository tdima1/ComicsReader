using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComicsReader.Models
{
   public interface IComicBookRepository
   {
      public IEnumerable<ComicBook> AllComicBooks { get; }
      public IEnumerable<ComicBook> PopularComicBooks { get; }

      public ComicBook GetComicBookById(int id);
   }
}
