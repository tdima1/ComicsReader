using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComicsReader.Models
{
   public interface ICategoryRepository
   {
      public IEnumerable<Category> AllCategories { get; }
      public Category GetCategoryById(int id);
   }
}
