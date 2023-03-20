using BookNowMovie.Models;
using BookNowMovie.Services.IRepository.Base;

namespace BookNowMovie.Services.IRepository
{
    public interface ICartRepository : IBaseRepository<Cart>
    {
        public Task<Cart> GetMovieByName(string movieName);
    }
}
