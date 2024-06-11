using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Homework1006.Models;
namespace Homework1006.Controllers
{
    public class MoviesController : Controller
    {
        private readonly MovieContext _context;

        public MoviesController(MovieContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var topMovies = await _context.Movies.Take(12).ToListAsync();
            return View(topMovies);
        }
    }
}