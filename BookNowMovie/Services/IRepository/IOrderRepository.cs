using BookNowMovie.Models;
using BookNowMovie.Services.IRepository.Base;
using System.Threading.Tasks;

namespace BookNowMovie.Services.IRepository
{
    public interface IOrderRepository: IBaseRepository<Order>
    {
        public Task<IEnumerable<Order>> GetCurrentUserOrders(int userId);
    }
}
