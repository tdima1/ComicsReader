using System.Collections.Generic;

namespace ComicsReader.Models
{
   public class Category
   {
      public int Id { get; set; }
      public string Name { get; set; }
      public List<ComicBook> ComicBooks { get; set; }
   }
}