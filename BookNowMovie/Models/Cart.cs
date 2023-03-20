using System.ComponentModel.DataAnnotations;

namespace BookNowMovie.Models
{
    public class Cart
    {
        [Key]
        public int CartId { get; set; }
        public string MovieName { get; set; }
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        public bool Active { get; set; }

    }
}
