using BookNowMovie.AppDbContext;
using BookNowMovie.Models;
using BookNowMovie.Services.IRepository;
using BookNowMovie.Services.Repository.Base;
using Microsoft.EntityFrameworkCore;

namespace BookNowMovie.Services.Repository
{
    public class OrderDetailRepository : BaseRepository<OrderDetail>, IOrderDetailRepository
    {
        private readonly ApplicationDbContext _context;
        public OrderDetailRepository(ApplicationDbContext context) :base(context)
        {
            _context = context;
        }

        
                
    }
}
