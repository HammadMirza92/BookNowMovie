using System.ComponentModel.DataAnnotations;

namespace BookNowMovie.Models
{
    public class Producers
    {
        [Key]
        public int Id { get; set; }
        public string ProfilePictureUrl { get; set; }
        public string FullName { get; set; }
        public string Bio { get; set; }

        //Relationship
        public List<Movie> Movies { get; set; }
    }
}
