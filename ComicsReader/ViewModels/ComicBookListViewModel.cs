using ComicsReader.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComicsReader.ViewModels
{
   public class ComicBookListViewModel
   {
      public IEnumerable<ComicBook> ComicBooks { get; set; }
      public string Category { get; set; }
   }
}
