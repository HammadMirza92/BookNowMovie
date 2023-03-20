using System.ComponentModel.DataAnnotations;

namespace BookNowMovie.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Bio { get; set; }
        public string ProfilePictureUrl { get; set; }
        public ICollection<ActorMovies> ActorMovies { get; set; }
    }
}
