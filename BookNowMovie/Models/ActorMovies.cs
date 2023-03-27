using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookNowMovie.Models
{
    public class ActorMovies
    {
        [Key]
        public int Id { get; set; }
        public int ActorId { get; set; }
        public Actor Actors { get; set; }
        public int MovieId { get; set; }
     
    }
}
