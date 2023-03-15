namespace BookNowMovie.Models
{
    public class CartItem
    {
        public int CartId { get; set; }
        public string ItemName { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public int NewProp { get; set; }
    }
}
