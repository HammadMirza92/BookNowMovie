using BookNowMovie.AppDbContext;
using BookNowMovie.Models;
using BookNowMovie.Services.IRepository;
using BookNowMovie.Services.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BookNowMovie.Controllers
{
    public class ProducersController : Controller
    {
        private readonly IProducersRepository _producersRepository;
        private readonly IMovieRepository _movieRepository;
        public ProducersController(IProducersRepository producersRepository, IMovieRepository movieRepository)
        {
            _producersRepository = producersRepository;
            _movieRepository = movieRepository;
        }
        public async Task<IActionResult> Index()
        {
            var allProducers = await _producersRepository.GetAll();
            return View(allProducers);
        }

        public IActionResult Create()
        {
          /*  var allmovies =await _movieRepository.GetAll();
            ViewBag.Movies = allmovies.ToList();*/
            return PartialView();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Producers producer)
        {
            await _producersRepository.Add(producer);
            return RedirectToAction("Index");
        }

        
        public async Task<IActionResult> EditProducer(int id)
        {
            var data = await _producersRepository.GetById(id);
            if (data == null)
            {
                return View("NotFound");
            }
            return PartialView(data);
        }

        public IActionResult Edit(Producers producer)
        {
            _producersRepository.Update(producer);
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Detail(int id) 
        {
            var actorDetail = await _producersRepository.GetById(id);
          
            if (actorDetail == null)
            {
                return View("NotFound");
            }
            return PartialView(actorDetail);
        }
        public async Task<IActionResult> Delete(int id)
        {
          await  _producersRepository.Delete(id);
           return RedirectToAction("Index");
        }
    }
}
