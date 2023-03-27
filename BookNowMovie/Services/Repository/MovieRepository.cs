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

        public async override Task<Movie> GetById(int id)
        {
            var entities = await _context.Movies.Where(x=> x.Id == id)
                .Include(c => c.Cinemas)
                .Include(p=> p.Producers).FirstOrDefaultAsync();
            return entities;
        }
        public async override Task<IEnumerable<Movie>> GetAll()
        {
            var entities = await _context.Movies.Include(c=> c.Cinemas).Include(p=> p.Producers).ToListAsync();
            return entities;
        }

        public async Task<IEnumerable<Movie>> GetMovieByname(string MovieName, int price)
        {
            var entities = await _context.Movies.Include(x => x.Cinemas).Where(m=> m.Name == MovieName || m.Price == price).ToListAsync();
            return entities;
        }
        public async Task UpdateStock(int id , int stock)
        {
            var rt = await _context.Movies.Where(x=> x.Id == id).FirstOrDefaultAsync();

            rt.Stock = rt.Stock - stock;

            _context.Movies.Update(rt);
            await _context.SaveChangesAsync();
        }
    }
}
