using BookNowMovie.Enums;

namespace BookNowMovie.Models.Dto
{
    public class MovieDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public int Price { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public MovieCategory MovieCategory { get; set; }
        public int Stock { get; set; }

    }
}
