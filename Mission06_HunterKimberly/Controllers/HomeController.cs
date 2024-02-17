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
            return View();
        }

        [HttpPost]
        public IActionResult AddMovie(Movie response)
        {
            _context.Movies.Add(response);    // Add record to the database
            _context.SaveChanges();

            return View("SuccessMovieAdd", response);
        }

    }
}
