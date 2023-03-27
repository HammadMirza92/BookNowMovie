using BookNowMovie.Models;
using BookNowMovie.Services.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookNowAPI.Controllers
{
    [Route("api/Actors")]
    [ApiController]
    public class ActorController : ControllerBase
    {
       
        private readonly IActorRepository _actorRepository;
        public ActorController(IActorRepository actorRepository)
        {
            _actorRepository = actorRepository;
        }
        [HttpGet]
        public async Task<IEnumerable<Actor>> Index()
        {
            var allactors = await _actorRepository.GetAll();
            if (allactors == null)
            {
                return null;
            }
            return allactors;
        }
        [HttpGet]
        [Route("GetActorById/{id}")]
        public async Task<Actor> GetActorById(int id)
        {
            var actor = await _actorRepository.GetById(id);
            if (actor == null)
            {
                return null;
            }
            return actor;
        }
        [HttpPut]
        [Route("Edit")]
        public async Task Edit(Actor actor)
        {
            await _actorRepository.Update(actor);
            
        }
        [HttpPost]
        [Route("Add")]
        public async Task<Actor> Add(Actor actor)
        {
           var newactor =  await _actorRepository.Add(actor);
            
            return newactor;
        }
        [HttpDelete]
        [Route("Delete")]
        public async Task Delete(int id)
        {
            await _actorRepository.Delete(id);

          
        }
    }
}
