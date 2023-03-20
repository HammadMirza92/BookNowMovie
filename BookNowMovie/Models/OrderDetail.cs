using System.ComponentModel.DataAnnotations;

namespace BookNowMovie.Models
{
    public class OrderDetail
    {
        [Key]
        public int Id { get; set; }
        public int OrderId { get; set; }
        public string Movie { get; set; }
        public Order Orders { get; set; }
    }
}
