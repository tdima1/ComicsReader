using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComicsReader.Models.DbContexts
{
   public class AppDbContext : DbContext
   {
      public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
      {
         
      }
      public DbSet<ComicBook> ComicBooks { get; set; }
      public DbSet<Category> Categories { get; set; }
   }
}
