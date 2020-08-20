using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ComicsReader.Models;
using ComicsReader.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ComicsReader.Controllers
{
   public class HomeController : Controller
   {
      private readonly IComicBookRepository _comicBooksRepository;
      private readonly ICategoryRepository _categoryRepository;

      public HomeController(IComicBookRepository comicBookRepository, ICategoryRepository categoryRepository)
      {
         _comicBooksRepository = comicBookRepository;
         _categoryRepository = categoryRepository;
      }

      [HttpGet]
      public ViewResult List()
      {
         ComicBookListViewModel comicBookListViewModel = new ComicBookListViewModel();
         comicBookListViewModel.ComicBooks = _comicBooksRepository.AllComicBooks;
         comicBookListViewModel.Category = "whatever im tired";

         return View(comicBookListViewModel);
      }
   }
}
