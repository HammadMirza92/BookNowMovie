using BookNowMovie.AppDbContext;
using BookNowMovie.Enums;
using BookNowMovie.Models;
using BookNowMovie.Services.IRepository;
using BookNowMovie.Services.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Drawing;

namespace BookNowMovie.Controllers
{
    public class MovieController : Controller
    {
        private readonly IMovieRepository _movieRepository;
        private readonly IProducersRepository _producersRepository;
        private readonly ICinemaRepository _cinemaRepository;
        public MovieController(IMovieRepository movieRepository, IProducersRepository producersRepository, ICinemaRepository cinemaRepository)
        {
            _movieRepository = movieRepository;
            _producersRepository = producersRepository;
            _cinemaRepository = cinemaRepository;
        }
        public async Task<IActionResult> Index()
        {
            var allMovies = await _movieRepository.GetAll();
            if (allMovies == null)
            {
                return View("NotFound");
            }
            return View(allMovies);
        }

        public async Task<IActionResult> Create()
        {
            ViewBag.producer = await _producersRepository.GetAll();
            ViewBag.Cinema = await _cinemaRepository.GetAll();

            List<MovieCategory> MovieCategory = Enum.GetValues(typeof(MovieCategory)).Cast<MovieCategory>().ToList();
            ViewBag.data = MovieCategory;


            return PartialView();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Movie movie)
        {
            await _movieRepository.Add(movie);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> EditMovie(int id)
        {
            var movie = await _movieRepository.GetById(id);
            ViewBag.producer = await _producersRepository.GetAll();
            ViewBag.Cinema = await _cinemaRepository.GetAll();

            List<MovieCategory> MovieCategory = Enum.GetValues(typeof(MovieCategory)).Cast<MovieCategory>().ToList();
            ViewBag.data = MovieCategory;

            if (movie == null)
            {
                return View("NotFound");
            }
            return PartialView(movie);

        }
        [HttpPost]
        public async Task<IActionResult> Edit(Movie movie)
        {
            _movieRepository.Update(movie);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(int id)
        {
            _movieRepository.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
