using BookNowMovie.Models;
using BookNowMovie.Services.IRepository.Base;

namespace BookNowMovie.Services.IRepository
{
    public interface IMovieRepository :IBaseRepository<Movie>
    {
        public Task UpdateStock(int id, int stock);
        public Task<IEnumerable<Movie>> GetMovieByname(string MovieName, int price);
    }
}
