using System.ComponentModel.DataAnnotations;

namespace BookNowMovie.Models
{
    public class OrderDetail
    {
        [Key]
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int MovieId { get; set; }
        public string MovieName { get; set; }
        public int Quantity { get; set; }
        public Order Orders { get; set; }
    }
}
