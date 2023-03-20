﻿// <auto-generated />
using System;
using BookNowMovie.AppDbContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BookNowMovie.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230320083111_activeCart")]
    partial class activeCart
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BookNowMovie.Models.Actor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Bio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfilePictureUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Actors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Bio = "This is the Bio of the first actor",
                            FullName = "Actor 1",
                            ProfilePictureUrl = "http://dotnethow.net/images/actors/actor-1.jpeg"
                        },
                        new
                        {
                            Id = 2,
                            Bio = "This is the Bio of the second actor",
                            FullName = "Actor 2",
                            ProfilePictureUrl = "http://dotnethow.net/images/actors/actor-2.jpeg"
                        },
                        new
                        {
                            Id = 3,
                            Bio = "This is the Bio of the second actor",
                            FullName = "Actor 3",
                            ProfilePictureUrl = "http://dotnethow.net/images/actors/actor-3.jpeg"
                        },
                        new
                        {
                            Id = 4,
                            Bio = "This is the Bio of the second actor",
                            FullName = "Actor 4",
                            ProfilePictureUrl = "http://dotnethow.net/images/actors/actor-4.jpeg"
                        },
                        new
                        {
                            Id = 5,
                            Bio = "This is the Bio of the second actor",
                            FullName = "Actor 5",
                            ProfilePictureUrl = "http://dotnethow.net/images/actors/actor-5.jpeg"
                        });
                });

            modelBuilder.Entity("BookNowMovie.Models.ActorMovies", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ActorId")
                        .HasColumnType("int");

                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ActorId");

                    b.HasIndex("MovieId");

                    b.ToTable("ActorMovies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ActorId = 1,
                            MovieId = 1
                        },
                        new
                        {
                            Id = 2,
                            ActorId = 3,
                            MovieId = 1
                        },
                        new
                        {
                            Id = 3,
                            ActorId = 1,
                            MovieId = 2
                        },
                        new
                        {
                            Id = 4,
                            ActorId = 4,
                            MovieId = 2
                        },
                        new
                        {
                            Id = 5,
                            ActorId = 1,
                            MovieId = 3
                        },
                        new
                        {
                            Id = 6,
                            ActorId = 2,
                            MovieId = 3
                        },
                        new
                        {
                            Id = 7,
                            ActorId = 5,
                            MovieId = 3
                        },
                        new
                        {
                            Id = 8,
                            ActorId = 2,
                            MovieId = 4
                        },
                        new
                        {
                            Id = 9,
                            ActorId = 3,
                            MovieId = 4
                        },
                        new
                        {
                            Id = 10,
                            ActorId = 4,
                            MovieId = 4
                        });
                });

            modelBuilder.Entity("BookNowMovie.Models.Cart", b =>
                {
                    b.Property<int>("CartId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CartId"), 1L, 1);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("MovieName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("CartId");

                    b.ToTable("CartItems");
                });

            modelBuilder.Entity("BookNowMovie.Models.Cinema", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Logo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Cinemas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "This is the description of the first cinema",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-1.jpeg",
                            Name = "Cinema 1"
                        },
                        new
                        {
                            Id = 2,
                            Description = "This is the description of the first cinema",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-2.jpeg",
                            Name = "Cinema 2"
                        },
                        new
                        {
                            Id = 3,
                            Description = "This is the description of the first cinema",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-3.jpeg",
                            Name = "Cinema 3"
                        },
                        new
                        {
                            Id = 4,
                            Description = "This is the description of the first cinema",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-4.jpeg",
                            Name = "Cinema 4"
                        },
                        new
                        {
                            Id = 5,
                            Description = "This is the description of the first cinema",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-5.jpeg",
                            Name = "Cinema 5"
                        });
                });

            modelBuilder.Entity("BookNowMovie.Models.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CinemaId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MovieCategory")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int>("ProducerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDateTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CinemaId");

                    b.HasIndex("ProducerId");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CinemaId = 3,
                            Description = "This is the Life movie description",
                            EndDateTime = new DateTime(2023, 3, 30, 13, 31, 11, 478, DateTimeKind.Local).AddTicks(2155),
                            ImageUrl = "http://dotnethow.net/images/movies/movie-3.jpeg",
                            MovieCategory = 6,
                            Name = "Life",
                            Price = 39,
                            ProducerId = 3,
                            StartDateTime = new DateTime(2023, 3, 10, 13, 31, 11, 478, DateTimeKind.Local).AddTicks(2142)
                        },
                        new
                        {
                            Id = 2,
                            CinemaId = 1,
                            Description = "This is the Shawshank Redemption description",
                            EndDateTime = new DateTime(2023, 3, 23, 13, 31, 11, 478, DateTimeKind.Local).AddTicks(2167),
                            ImageUrl = "http://dotnethow.net/images/movies/movie-1.jpeg",
                            MovieCategory = 1,
                            Name = "The Shawshank Redemption",
                            Price = 29,
                            ProducerId = 1,
                            StartDateTime = new DateTime(2023, 3, 20, 13, 31, 11, 478, DateTimeKind.Local).AddTicks(2166)
                        },
                        new
                        {
                            Id = 3,
                            CinemaId = 4,
                            Description = "This is the Ghost movie description",
                            EndDateTime = new DateTime(2023, 3, 27, 13, 31, 11, 478, DateTimeKind.Local).AddTicks(2179),
                            ImageUrl = "http://dotnethow.net/images/movies/movie-4.jpeg",
                            MovieCategory = 7,
                            Name = "Ghost",
                            Price = 67,
                            ProducerId = 4,
                            StartDateTime = new DateTime(2023, 3, 20, 13, 31, 11, 478, DateTimeKind.Local).AddTicks(2179)
                        },
                        new
                        {
                            Id = 4,
                            CinemaId = 1,
                            Description = "This is the Race movie description",
                            EndDateTime = new DateTime(2023, 3, 15, 13, 31, 11, 478, DateTimeKind.Local).AddTicks(2187),
                            ImageUrl = "http://dotnethow.net/images/movies/movie-6.jpeg",
                            MovieCategory = 6,
                            Name = "Race",
                            Price = 71,
                            ProducerId = 2,
                            StartDateTime = new DateTime(2023, 3, 10, 13, 31, 11, 478, DateTimeKind.Local).AddTicks(2186)
                        },
                        new
                        {
                            Id = 5,
                            CinemaId = 1,
                            Description = "This is the Scoob movie description",
                            EndDateTime = new DateTime(2023, 3, 18, 13, 31, 11, 478, DateTimeKind.Local).AddTicks(2236),
                            ImageUrl = "http://dotnethow.net/images/movies/movie-7.jpeg",
                            MovieCategory = 5,
                            Name = "Scoob",
                            Price = 90,
                            ProducerId = 3,
                            StartDateTime = new DateTime(2023, 3, 10, 13, 31, 11, 478, DateTimeKind.Local).AddTicks(2235)
                        },
                        new
                        {
                            Id = 6,
                            CinemaId = 1,
                            Description = "This is the Cold Soles movie description",
                            EndDateTime = new DateTime(2023, 4, 9, 13, 31, 11, 478, DateTimeKind.Local).AddTicks(2248),
                            ImageUrl = "http://dotnethow.net/images/movies/movie-8.jpeg",
                            MovieCategory = 3,
                            Name = "Cold Soles",
                            Price = 44,
                            ProducerId = 5,
                            StartDateTime = new DateTime(2023, 3, 23, 13, 31, 11, 478, DateTimeKind.Local).AddTicks(2248)
                        });
                });

            modelBuilder.Entity("BookNowMovie.Models.Producers", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Bio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfilePictureUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Producers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Bio = "This is the Bio of the first actor",
                            FullName = "Producer 1",
                            ProfilePictureUrl = "http://dotnethow.net/images/producers/producer-1.jpeg"
                        },
                        new
                        {
                            Id = 2,
                            Bio = "This is the Bio of the second actor",
                            FullName = "Producer 2",
                            ProfilePictureUrl = "http://dotnethow.net/images/producers/producer-2.jpeg"
                        },
                        new
                        {
                            Id = 3,
                            Bio = "This is the Bio of the second actor",
                            FullName = "Producer 3",
                            ProfilePictureUrl = "http://dotnethow.net/images/producers/producer-3.jpeg"
                        },
                        new
                        {
                            Id = 4,
                            Bio = "This is the Bio of the second actor",
                            FullName = "Producer 4",
                            ProfilePictureUrl = "http://dotnethow.net/images/producers/producer-4.jpeg"
                        },
                        new
                        {
                            Id = 5,
                            Bio = "This is the Bio of the second actor",
                            FullName = "Producer 5",
                            ProfilePictureUrl = "http://dotnethow.net/images/producers/producer-5.jpeg"
                        });
                });

            modelBuilder.Entity("BookNowMovie.Models.ActorMovies", b =>
                {
                    b.HasOne("BookNowMovie.Models.Actor", "Actor")
                        .WithMany("ActorMovies")
                        .HasForeignKey("ActorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookNowMovie.Models.Movie", "Movie")
                        .WithMany("ActorMovies")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Actor");

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("BookNowMovie.Models.Movie", b =>
                {
                    b.HasOne("BookNowMovie.Models.Cinema", "Cinemas")
                        .WithMany("Movies")
                        .HasForeignKey("CinemaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookNowMovie.Models.Producers", "Producers")
                        .WithMany("Movies")
                        .HasForeignKey("ProducerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cinemas");

                    b.Navigation("Producers");
                });

            modelBuilder.Entity("BookNowMovie.Models.Actor", b =>
                {
                    b.Navigation("ActorMovies");
                });

            modelBuilder.Entity("BookNowMovie.Models.Cinema", b =>
                {
                    b.Navigation("Movies");
                });

            modelBuilder.Entity("BookNowMovie.Models.Movie", b =>
                {
                    b.Navigation("ActorMovies");
                });

            modelBuilder.Entity("BookNowMovie.Models.Producers", b =>
                {
                    b.Navigation("Movies");
                });
#pragma warning restore 612, 618
        }
    }
}
