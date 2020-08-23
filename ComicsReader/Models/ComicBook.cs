using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComicsReader.Models
{
   public class ComicBook
   {
      public int Id { get; set; }
      public string Title { get; set; }
      public int NumberOfPages { get; set; }
      public decimal Price { get; set; }
      public Category Category { get; set; }
      public bool IsPopular { get; set; }
      public string ImageThumbnailUrl { get; set; }

      public override string ToString()
      {
         return $"{Title}, {Category.Name}, \nPrice: {Price}";
      }
   }
}
