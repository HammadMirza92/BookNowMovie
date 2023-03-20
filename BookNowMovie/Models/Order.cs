using System.ComponentModel.DataAnnotations;

namespace BookNowMovie.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        public int Total { get; set; }

        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public string UserPhone { get; set; }
    }
}
