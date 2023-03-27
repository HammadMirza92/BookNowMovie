using BookNowMovie.AppDbContext;
using BookNowMovie.Models;
using BookNowMovie.Services.IRepository;
using BookNowMovie.Services.Repository.Base;
using Microsoft.EntityFrameworkCore;

namespace BookNowMovie.Services.Repository
{
    public class ActorRepository : BaseRepository<Actor>, IActorRepository 
    {
        private readonly ApplicationDbContext _context;
        public ActorRepository(ApplicationDbContext context) :base(context)
        {
            _context = context;
        }
       
        public async override Task<Actor> GetById(int id)
        {
            var entities = await _context.Actors.Where(x => x.Id == id)
                .Include(am => am.ActorMovies).FirstOrDefaultAsync();
            return entities;
        }

    }
}
