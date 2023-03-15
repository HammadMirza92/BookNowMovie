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
        public double Price { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public MovieCategory MovieCategory { get; set; }

        //Relationships

        public List<ActorMovies> ActorMovies { get; set; }

        //Cinema 
        public int CinemaId { get; set; }
        [ForeignKey(nameof(CinemaId))]
        public Cinema Cinema { get; set; }

        //Producers 
        public int ProducerId { get; set; }
        [ForeignKey(nameof(ProducerId))]
        public Producers Producers { get; set; }
    }
}
