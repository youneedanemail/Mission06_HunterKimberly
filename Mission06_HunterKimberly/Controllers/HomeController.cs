using Microsoft.AspNetCore.Mvc;
using Mission06_HunterKimberly.Models;
using System.Diagnostics;

namespace Mission06_HunterKimberly.Controllers
{
    public class HomeController : Controller
    {
        private AddMovieContext _context;
        public HomeController(AddMovieContext context) 
        {
            _context = context;
        }
        

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddMovie()
        {
            ViewBag.Categories = _context.Categories  // populates viewbag vor category
                .OrderBy(x => x.CategoryName)
                .ToList();

            return View();
        }

        [HttpPost]
        public IActionResult AddMovie(Movie response)
        {
            _context.Movies.Add(response);    // Add record to the database
            _context.SaveChanges();

            return View("SuccessMovieAdd", response);
        }

        public IActionResult MovieList()
        {
            // Link  (sequal language)
            var movies = _context.Movies
                .OrderBy(x => x.Title).ToList();

            return View(movies);
        }

        // Edit Movie
        [HttpGet]
        public IActionResult Edit(int id) 
        {
            var recordToEdit = _context.Movies
                .Single(x => x.MovieId == id);

            ViewBag.Categories = _context.Categories  // populates viewbag vor category
                .OrderBy(x => x.CategoryName)
                .ToList();

            return View("AddMovie", recordToEdit);
        }

        [HttpPost]
        public IActionResult Edit(Movie updateInfo) 
        {
            _context.Update(updateInfo);
            _context.SaveChanges();


            return RedirectToAction("MovieList");
        }

        // Delete Movie Link
        [HttpGet]
        public IActionResult Delete(int id) 
        {
            var recordToDelete = _context.Movies
                .Single(x => x.MovieId == id);


            return View(recordToDelete);
        }

        // Delete Movie Action
        [HttpPost]
        public IActionResult Delete(Movie updateInfo)
        {
            _context.Movies.Remove(updateInfo);
            _context.SaveChanges();

            return RedirectToAction("MovieList");
        }
    }
}
