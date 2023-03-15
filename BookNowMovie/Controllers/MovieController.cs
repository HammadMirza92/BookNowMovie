using BookNowMovie.AppDbContext;
using BookNowMovie.Services.IRepository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BookNowMovie.Controllers
{
    public class MovieController : Controller
    {
        private readonly IMovieRepository _movieRepository;
        public MovieController(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }
        public async Task<IActionResult> Index()
        {
            var allMovies = await _movieRepository.GetAll();
            return View(allMovies);
        }
    }
}
