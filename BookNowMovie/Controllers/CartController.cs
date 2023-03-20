using BookNowMovie.Models;
using BookNowMovie.Services.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace BookNowMovie.Controllers
{
    public class CartController : Controller
    {
        private readonly ICartRepository _cartRepository;
        private readonly IMovieRepository _movieRepository;
        public CartController(ICartRepository cartRepository,IMovieRepository movieRepository)
        {
            _cartRepository = cartRepository;
            _movieRepository = movieRepository;
        }
        public async Task<IActionResult> Index()
        {
            var cartItems =await _cartRepository.GetAll();
            if (cartItems == null)
            {
                return View("NotFound");
            }
            return View(cartItems);
        }
        public async Task<IActionResult> CreateCart(int id)
        {
            var movie = await _movieRepository.GetById(id);
            var check = await _cartRepository.GetMovieByName(movie.Name);
            if (check !=null)
            {
               
                Cart item = new Cart()
                {
                    CartId = check.CartId,
                    MovieName = check.MovieName,
                    Quantity = check.Quantity + 1,
                    Price = check.Price + movie.Price,
                    Active = true
                };
                await _cartRepository.Update(item);
                
            }
            else
            {
                Cart item = new Cart()
                {
                    MovieName = movie.Name,
                    Quantity = 1,
                    Price = movie.Price,
                    Active = true
                };
                await _cartRepository.Add(item);
            }
           
          
            return RedirectToAction("Index");
        }
    }
}
