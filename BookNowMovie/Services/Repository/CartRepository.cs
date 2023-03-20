using BookNowMovie.AppDbContext;
using BookNowMovie.Models;
using BookNowMovie.Services.IRepository;
using BookNowMovie.Services.Repository.Base;
using Microsoft.EntityFrameworkCore;

namespace BookNowMovie.Services.Repository
{
    public class CartRepository : BaseRepository<Cart>, ICartRepository
    {
        private readonly ApplicationDbContext _context;
        public CartRepository(ApplicationDbContext context) :base(context)
        
        {
            _context = context;
        }

        public async Task<Cart> GetMovieByName(string movieName)
        {
            var cartMovie = await _context.CartItems.Where(x => x.MovieName == movieName).FirstOrDefaultAsync();
            return cartMovie;
        }

    }
}
