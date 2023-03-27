using AutoMapper;
using BookNowMovie.Models;
using BookNowMovie.Models.Dto;

namespace BookNowMovie.MappingProfiles
{
    public class MappingProfiles :Profile
    {
        public MappingProfiles()
        {
            CreateMap<Actor,ActorDto>().ReverseMap(); 
        }
    }
}
