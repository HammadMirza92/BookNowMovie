using BookNowMovie.Models;
using BookNowMovie.Services.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace BookNowMovie.Controllers
{
    public class ActorsController : Controller
    {
        private readonly IActorRepository _actorRepository;
        public ActorsController(IActorRepository actorRepository)
        {
            _actorRepository = actorRepository;
        }
        public async Task<IActionResult> Index()
        {
            var allActors = await _actorRepository.GetAll();
            if (allActors == null)
            {
                return View("NotFound");
            }
            return View(allActors);
        }
        public IActionResult Create()
        {
            return PartialView();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Actor actor)
        {
            _actorRepository.Add(actor);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public async Task<IActionResult> GetActorById(int id)
        {
            var actor = await _actorRepository.GetById(id);
            if (actor == null)
            {
                return View("NotFound");
            }
            return PartialView(actor);
        }
        public async Task<IActionResult> EditActor(int id)
        { 
            var data = await _actorRepository.GetById(id);
            if (data == null)
            {
                return View("NotFound");
            }
            return PartialView(data);
         
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Actor actor)
        {
             _actorRepository.Update(actor);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(int id)
        {
           await _actorRepository.Delete(id);
            return RedirectToAction("Index");
        }

    }
}
