using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComicsReader.Models
{
   public class MockCategoryRepository : ICategoryRepository
   {
      public IEnumerable<Category> AllCategories => new List<Category>{
         new Category{Id = 1, Name="Batman"},
         new Category{Id = 2, Name="Superman"},
         new Category{Id = 3, Name="Flash"}
      };

      public Category GetCategoryById(int id)
      {
         return AllCategories.First(c => c.Id == id);
      }
   }
}
