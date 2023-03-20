using System.ComponentModel.DataAnnotations;

namespace BookNowMovie.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
    }
}
