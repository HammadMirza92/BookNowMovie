using BookNowMovie.Models;
using BookNowMovie.Services.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace RestAPI.Controllers
{
   
    [Route("api/actors")]
    public class ActorController : Controller
    {
        private readonly IActorRepository _actorRepository;
        public ActorController(IActorRepository actorRepository)
        {
            _actorRepository = actorRepository;
        }
        [HttpGet]
        public async Task<IEnumerable<Actor>> Index()
        {
            var data =await  _actorRepository.GetAll();
            return data;
        }
    }
}
