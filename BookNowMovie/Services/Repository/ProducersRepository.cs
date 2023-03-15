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
       
                
    }
}
