using BookNowMovie.AppDbContext; 
using BookNowMovie.Services.IRepository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BookNowMovie.Controllers
{
    public class ProducersController : Controller
    {
        private readonly IProducersRepository _producersRepository;
        public ProducersController(IProducersRepository producersRepository)
        {
            _producersRepository = producersRepository;
        }
        public async Task<IActionResult> Index()
        {
            var allProducers = await _producersRepository.GetAll();
            return View(allProducers);
        }
    }
}
