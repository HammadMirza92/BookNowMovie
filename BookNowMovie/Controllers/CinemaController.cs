
using BookNowMovie.Models;
using BookNowMovie.Services.IRepository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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
            if (allCinemas == null)
            {
                return View("NotFound");
            }
            return View(allCinemas);
        }
        public IActionResult Create()
        {
 /*           var movies = _movieRepository.GetAll().Result.Select(x=>new {Id= x.Id,Title=x.Name}).ToList();
            ViewBag.test = new SelectList(movies);
            */
            return PartialView();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Cinema cinema)
        {
            await _cinemaRepository.Add(cinema);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> EditCinema(int id)
        {
            var cinema = await _cinemaRepository.GetById(id);
            if (cinema == null)
            {
                return View("NotFound");
            }
            return PartialView(cinema);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Cinema cinema)
        {
            _cinemaRepository.Update(cinema);
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Detail(int id)
        {
            var cinema = await _cinemaRepository.GetById(id);
            if (cinema == null)
            {
                return View("NotFound");
            }
            return PartialView(cinema);
        }

        public async Task<IActionResult> Delete(int id)
        {
             _cinemaRepository.Delete(id);
          
            return RedirectToAction("Index");
        }

    }
}
