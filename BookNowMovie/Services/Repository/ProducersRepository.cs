using BookNowMovie.AppDbContext;
using BookNowMovie.Models;
using BookNowMovie.Services.IRepository;
using BookNowMovie.Services.Repository.Base;
using Microsoft.EntityFrameworkCore;

namespace BookNowMovie.Services.Repository
{
    public class ProducersRepository :BaseRepository<Producers>, IProducersRepository
    {
        private readonly ApplicationDbContext _context;
        public ProducersRepository(ApplicationDbContext context):base(context) 
        {
            _context = context;
        }

        public async override Task<IEnumerable<Producers>> GetAll()
        {
            var entities = await _context.Producers
                .Include(m => m.Movies)
                .ThenInclude(c=> c.Cinemas)
                .ToListAsync();
            return entities;
        }
    }
}
