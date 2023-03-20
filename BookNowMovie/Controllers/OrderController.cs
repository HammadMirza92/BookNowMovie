using BookNowMovie.Services.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace BookNowMovie.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderRepository _orderRepository;
        public OrderController(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
