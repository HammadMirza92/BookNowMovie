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

        
                
    }
}
