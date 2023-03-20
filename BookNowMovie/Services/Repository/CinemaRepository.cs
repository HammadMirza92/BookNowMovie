using BookNowMovie.AppDbContext;
using BookNowMovie.Models;
using BookNowMovie.Services.IRepository;
using BookNowMovie.Services.Repository.Base;
using Microsoft.EntityFrameworkCore;

namespace BookNowMovie.Services.Repository
{
    public class CinemaRepository :BaseRepository<Cinema>, ICinemaRepository
    {
        private readonly ApplicationDbContext _context;
        public CinemaRepository(ApplicationDbContext context):base(context) 
        {
            _context = context;
        }

        public async override Task<IEnumerable<Cinema>> GetAll()
        {
            var entities = await _context.Cinemas.Include(x => x.Movies).ToListAsync();
            return entities;
        }
    }
}
