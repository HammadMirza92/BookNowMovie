using BookNowMovie.Enums;
using BookNowMovie.Models;
using Microsoft.EntityFrameworkCore;

namespace BookNowMovie.AppDbContext
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options)
        {
            
        }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Cinema> Cinemas { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Producers> Producers { get; set; }
        public DbSet<ActorMovies> ActorMovies { get; set; }
        public DbSet<Cart> Cart { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Users> users{ get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Cinema>().HasData(new Cinema
            {
                Id = 1,
                Name = "Cinema 1",
                Logo = "http://dotnethow.net/images/cinemas/cinema-1.jpeg",
                Description = "This is the description of the first cinema"
            });

            modelBuilder.Entity<Cinema>().HasData(new Cinema
            {
                Id = 2,
                Name = "Cinema 2",
                Logo = "http://dotnethow.net/images/cinemas/cinema-2.jpeg",
                Description = "This is the description of the first cinema"
            });
            modelBuilder.Entity<Cinema>().HasData(new Cinema
            {
                Id = 3,
                Name = "Cinema 3",
                Logo = "http://dotnethow.net/images/cinemas/cinema-3.jpeg",
                Description = "This is the description of the first cinema"
            });
            modelBuilder.Entity<Cinema>().HasData(new Cinema
            {
                Id = 4,
                Name = "Cinema 4",
                Logo = "http://dotnethow.net/images/cinemas/cinema-4.jpeg",
                Description = "This is the description of the first cinema"
            });
            modelBuilder.Entity<Cinema>().HasData(new Cinema
            {
                Id = 5,
                Name = "Cinema 5",
                Logo = "http://dotnethow.net/images/cinemas/cinema-5.jpeg",
                Description = "This is the description of the first cinema"

            });



            modelBuilder.Entity<Actor>().HasData(new Actor
            {
                Id = 1,
                FullName = "Actor 1",
                Bio = "This is the Bio of the first actor",
                ProfilePictureUrl = "http://dotnethow.net/images/actors/actor-1.jpeg"

            });
            modelBuilder.Entity<Actor>().HasData(new Actor
            {
                Id = 2,
                FullName = "Actor 2",
                Bio = "This is the Bio of the second actor",
                ProfilePictureUrl = "http://dotnethow.net/images/actors/actor-2.jpeg"
            });
            modelBuilder.Entity<Actor>().HasData(new Actor
            {
                Id = 3,
                FullName = "Actor 3",
                Bio = "This is the Bio of the second actor",
                ProfilePictureUrl = "http://dotnethow.net/images/actors/actor-3.jpeg"
            });
            modelBuilder.Entity<Actor>().HasData(new Actor
            {
                Id = 4,
                FullName = "Actor 4",
                Bio = "This is the Bio of the second actor",
                ProfilePictureUrl = "http://dotnethow.net/images/actors/actor-4.jpeg"
            });
            modelBuilder.Entity<Actor>().HasData(new Actor
            {
                Id = 5,
                FullName = "Actor 5",
                Bio = "This is the Bio of the second actor",
                ProfilePictureUrl = "http://dotnethow.net/images/actors/actor-5.jpeg"
            });



            modelBuilder.Entity<Producers>().HasData(new Producers
            {
                Id = 1,
                FullName = "Producer 1",
                Bio = "This is the Bio of the first actor",
                ProfilePictureUrl = "http://dotnethow.net/images/producers/producer-1.jpeg"
            });
            modelBuilder.Entity<Producers>().HasData(new Producers
            {
                Id = 2,
                FullName = "Producer 2",
                Bio = "This is the Bio of the second actor",
                ProfilePictureUrl = "http://dotnethow.net/images/producers/producer-2.jpeg"
            });
            modelBuilder.Entity<Producers>().HasData(new Producers
            {
                Id = 3,
                FullName = "Producer 3",
                Bio = "This is the Bio of the second actor",
                ProfilePictureUrl = "http://dotnethow.net/images/producers/producer-3.jpeg"
            });
            modelBuilder.Entity<Producers>().HasData(new Producers
            {
                Id = 4,
                FullName = "Producer 4",
                Bio = "This is the Bio of the second actor",
                ProfilePictureUrl = "http://dotnethow.net/images/producers/producer-4.jpeg"

            });
            modelBuilder.Entity<Producers>().HasData(new Producers
            {
                Id = 5,
                FullName = "Producer 5",
                Bio = "This is the Bio of the second actor",
                ProfilePictureUrl = "http://dotnethow.net/images/producers/producer-5.jpeg"

            });


            modelBuilder.Entity<Movie>().HasData(new Movie
            {
                Id = 1,
                Name = "Life",
                Description = "This is the Life movie description",
                Price = 39,
                ImageUrl = "http://dotnethow.net/images/movies/movie-3.jpeg",
                StartDateTime = DateTime.Now.AddDays(-10),
                EndDateTime = DateTime.Now.AddDays(10),
                CinemaId = 3,
                Stock = 23,
                ProducerId = 3,
                MovieCategory = MovieCategory.Documentary

            });
            modelBuilder.Entity<Movie>().HasData(new Movie
            {
                Id = 2,
                Name = "The Shawshank Redemption",
                Description = "This is the Shawshank Redemption description",
                Price = 29,
                ImageUrl = "http://dotnethow.net/images/movies/movie-1.jpeg",
                StartDateTime = DateTime.Now,
                EndDateTime = DateTime.Now.AddDays(3),
                CinemaId = 1,
                Stock = 29,
                ProducerId = 1,
                MovieCategory = MovieCategory.Action

            });
            modelBuilder.Entity<Movie>().HasData(new Movie
            {
                Id = 3,
                Name = "Ghost",
                Description = "This is the Ghost movie description",
                Price = 67,
                ImageUrl = "http://dotnethow.net/images/movies/movie-4.jpeg",
                StartDateTime = DateTime.Now,
                EndDateTime = DateTime.Now.AddDays(7),
                CinemaId = 4,
                Stock = 99,
                ProducerId = 4,
                MovieCategory = MovieCategory.Horror

            });
            modelBuilder.Entity<Movie>().HasData(new Movie
            {
                Id = 4,
                Name = "Race",
                Description = "This is the Race movie description",
                Price = 71,
                ImageUrl = "http://dotnethow.net/images/movies/movie-6.jpeg",
                StartDateTime = DateTime.Now.AddDays(-10),
                EndDateTime = DateTime.Now.AddDays(-5),
                CinemaId = 1,
                Stock = 88,
                ProducerId = 2,
                MovieCategory = MovieCategory.Documentary

            });
            modelBuilder.Entity<Movie>().HasData(new Movie
            {
                Id = 5,
                Name = "Scoob",
                Description = "This is the Scoob movie description",
                Price = 90,
                ImageUrl = "http://dotnethow.net/images/movies/movie-7.jpeg",
                StartDateTime = DateTime.Now.AddDays(-10),
                EndDateTime = DateTime.Now.AddDays(-2),
                Stock = 43,
                CinemaId = 1,
                ProducerId = 3,
                MovieCategory = MovieCategory.Cartoon

            });
            modelBuilder.Entity<Movie>().HasData(new Movie
            {
                Id = 6,
                Name = "Cold Soles",
                Description = "This is the Cold Soles movie description",
                Price = 44,
                ImageUrl = "http://dotnethow.net/images/movies/movie-8.jpeg",
                StartDateTime = DateTime.Now.AddDays(3),
                EndDateTime = DateTime.Now.AddDays(20),
                CinemaId = 1,
                Stock = 83,
                ProducerId = 5,
                MovieCategory = MovieCategory.Darama

            });



            modelBuilder.Entity<ActorMovies>().HasData(new ActorMovies
            {
                Id = 1,
                ActorId = 1,
                MovieId = 1
            });
            modelBuilder.Entity<ActorMovies>().HasData(new ActorMovies
            {

                Id = 2,
                ActorId = 3,
                MovieId = 1
            });
            modelBuilder.Entity<ActorMovies>().HasData(new ActorMovies
            {
                Id = 3,
                ActorId = 1,
                MovieId = 2
            });
            modelBuilder.Entity<ActorMovies>().HasData(new ActorMovies
            {
                Id = 4,
                ActorId = 4,
                MovieId = 2
            });
            modelBuilder.Entity<ActorMovies>().HasData(new ActorMovies
            {
                Id = 5,
                ActorId = 1,
                MovieId = 3

            });
            modelBuilder.Entity<ActorMovies>().HasData(new ActorMovies
            {
                Id = 6,
                ActorId = 2,
                MovieId = 3
            });
            modelBuilder.Entity<ActorMovies>().HasData(new ActorMovies
            {
                Id = 7,
                ActorId = 5,
                MovieId = 3
            });
            modelBuilder.Entity<ActorMovies>().HasData(new ActorMovies
            {
                Id = 8,
                ActorId = 2,
                MovieId = 4
            });
            modelBuilder.Entity<ActorMovies>().HasData(new ActorMovies
            {
                Id = 9,
                ActorId = 3,
                MovieId = 4
            });
            modelBuilder.Entity<ActorMovies>().HasData(new ActorMovies
            {
                Id = 10,
                ActorId = 4,
                MovieId = 4
            });

        }

    }
}
