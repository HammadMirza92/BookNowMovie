
using BookNowMovie.Services.IRepository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BookNowMovie.Controllers
{
    public class CinemaController : Controller
    {
        private readonly ICinemaRepository _cinemaRepository;
        public CinemaController(ICinemaRepository cinemaRepository)
        {
            _cinemaRepository = cinemaRepository;
        }
        public async Task<IActionResult> Index()
        {
            var allCinemas = await _cinemaRepository.GetAll();
            return View(allCinemas);
        }
    }
}
