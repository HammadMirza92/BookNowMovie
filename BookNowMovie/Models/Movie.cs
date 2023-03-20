using BookNowMovie.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookNowMovie.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public int Price { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public MovieCategory MovieCategory { get; set; }
        public int Stock { get; set; }

        //Relationships
        public int ProducerId { get; set; }
        [ForeignKey(nameof(ProducerId))]
        public Producers Producers { get; set; }
        public int CinemaId { get; set; }
        [ForeignKey(nameof(CinemaId))]
        public Cinema Cinemas { get; set; }

        public ICollection<ActorMovies> ActorMovies { get; set; }
        
    }
}
