using BookNowMovie.AppDbContext;
using BookNowMovie.Models;
using BookNowMovie.Services.IRepository;
using BookNowMovie.Services.Repository.Base;
using Microsoft.EntityFrameworkCore;

namespace BookNowMovie.Services.Repository
{
    public class MovieRepository :BaseRepository<Movie>, IMovieRepository
    {
        private readonly ApplicationDbContext _context;
        public MovieRepository(ApplicationDbContext context):base(context)
        {
            _context = context;
        }

        public async override Task<IEnumerable<Movie>> GetAll()
        {
            var entities = await _context.Movies.Include(x=> x.Cinema).ToListAsync();
            return entities;
        }
    }
}
