using BookNowMovie.Models;
using BookNowMovie.Services.IRepository;
using BookNowMovie.Services.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace BookNowMovie.Controllers
{
    public class CartController : Controller
    {
        private readonly ICartRepository _cartRepository;
        private readonly IMovieRepository _movieRepository;
        private readonly IOrderRepository _orderRepository;
        private readonly IOrderDetailRepository _orderDetailRepository;

        public CartController(ICartRepository cartRepository,IMovieRepository movieRepository, IOrderRepository orderRepository,IOrderDetailRepository orderDetailRepository)
        {
            _cartRepository = cartRepository;
            _movieRepository = movieRepository;
            _orderRepository= orderRepository;
            _orderDetailRepository= orderDetailRepository;
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
        public async Task<int> CartItemCount()
        {
            var cartItems = await _cartRepository.GetAll();
            var count = cartItems.Count();
            return count;
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
                    MovieId = movie.Id,
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
                    MovieId = movie.Id,
                    Quantity = 1,
                    Price = movie.Price,
                    Active = true
                };
                 await _cartRepository.Add(item);
            }
           
          
            return RedirectToAction("Index");
        }
        [HttpPost]
        [Route("cart/checkoutDb")]
        public async Task<IActionResult> checkoutDb(Users user)
        {
            var cartItems = await _cartRepository.GetAll();

            var totalPrice = CalculatePrice(cartItems);
            
            if (cartItems == null)
            {
                return RedirectToAction("Index");
            }
            else
            {
                Order order = new Order()
                {
                    UserId = 2,
                    Total = totalPrice,
                    UserName = user.UserName,
                    UserEmail = user.UserEmail,
                    UserPhone = user.UserPhone,
                };

                var cnrtOrder = await _orderRepository.Add(order);
                int count = 0;
               // var cnrtOrder = await _orderRepository.GetById();
                foreach (var item in cartItems)
                {
                    ++count;

                    if (item == null)
                    {
                        return null;
                    }
                    OrderDetail orderDetail = new OrderDetail()
                    {
                        OrderId = cnrtOrder.Id,
                        MovieId = item.MovieId,
                        MovieName = item.MovieName,
                        Quantity = item.Quantity,
                    };

                   var temp = await _orderDetailRepository.Add(orderDetail);
                    await _movieRepository.UpdateStock(item.MovieId, item.Quantity);
                    await _cartRepository.Delete(item.CartId);
                }

            }

     
            return RedirectToAction("Index");

            /*  return View();*/

        }

        public async Task<IActionResult> checkout()
        {
            var cartItems = await _cartRepository.GetAll();
            ViewBag.CartItems = cartItems;
            return View();

        }
        public async Task<IActionResult> myAccount(int userId)
        {
            var userOrder = await _orderRepository.GetCurrentUserOrders(2);

            return RedirectToAction("Index");

        }
        public async Task<IActionResult> Remove(int id)
        {
            await _cartRepository.Delete(id);
            return RedirectToAction("Index");
        }

        public int CalculatePrice(IEnumerable<Cart> cartItems)
        {
            int total = 0;

            foreach (var cartItem in cartItems)
            {
                total += cartItem.Price;
            }

            return total;
        }
    }
}
