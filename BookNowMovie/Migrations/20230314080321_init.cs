using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookNowMovie.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Actors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Bio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProfilePictureUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cinemas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Logo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cinemas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Producers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProfilePictureUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Bio = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Producers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    StartDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MovieCategory = table.Column<int>(type: "int", nullable: false),
                    CinemaId = table.Column<int>(type: "int", nullable: false),
                    ProducerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Movies_Cinemas_CinemaId",
                        column: x => x.CinemaId,
                        principalTable: "Cinemas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Movies_Producers_ProducerId",
                        column: x => x.ProducerId,
                        principalTable: "Producers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ActorMovies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ActorId = table.Column<int>(type: "int", nullable: false),
                    MovieId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActorMovies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ActorMovies_Actors_ActorId",
                        column: x => x.ActorId,
                        principalTable: "Actors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ActorMovies_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "Bio", "FullName", "ProfilePictureUrl" },
                values: new object[,]
                {
                    { 1, "This is the Bio of the first actor", "Actor 1", "http://dotnethow.net/images/actors/actor-1.jpeg" },
                    { 2, "This is the Bio of the second actor", "Actor 2", "http://dotnethow.net/images/actors/actor-2.jpeg" },
                    { 3, "This is the Bio of the second actor", "Actor 3", "http://dotnethow.net/images/actors/actor-3.jpeg" },
                    { 4, "This is the Bio of the second actor", "Actor 4", "http://dotnethow.net/images/actors/actor-4.jpeg" },
                    { 5, "This is the Bio of the second actor", "Actor 5", "http://dotnethow.net/images/actors/actor-5.jpeg" }
                });

            migrationBuilder.InsertData(
                table: "Cinemas",
                columns: new[] { "Id", "Description", "Logo", "Name" },
                values: new object[,]
                {
                    { 1, "This is the description of the first cinema", "http://dotnethow.net/images/cinemas/cinema-1.jpeg", "Cinema 1" },
                    { 2, "This is the description of the first cinema", "http://dotnethow.net/images/cinemas/cinema-2.jpeg", "Cinema 2" },
                    { 3, "This is the description of the first cinema", "http://dotnethow.net/images/cinemas/cinema-3.jpeg", "Cinema 3" },
                    { 4, "This is the description of the first cinema", "http://dotnethow.net/images/cinemas/cinema-4.jpeg", "Cinema 4" },
                    { 5, "This is the description of the first cinema", "http://dotnethow.net/images/cinemas/cinema-5.jpeg", "Cinema 5" }
                });

            migrationBuilder.InsertData(
                table: "Producers",
                columns: new[] { "Id", "Bio", "FullName", "ProfilePictureUrl" },
                values: new object[,]
                {
                    { 1, "This is the Bio of the first actor", "Producer 1", "http://dotnethow.net/images/producers/producer-1.jpeg" },
                    { 2, "This is the Bio of the second actor", "Producer 2", "http://dotnethow.net/images/producers/producer-2.jpeg" },
                    { 3, "This is the Bio of the second actor", "Producer 3", "http://dotnethow.net/images/producers/producer-3.jpeg" },
                    { 4, "This is the Bio of the second actor", "Producer 4", "http://dotnethow.net/images/producers/producer-4.jpeg" },
                    { 5, "This is the Bio of the second actor", "Producer 5", "http://dotnethow.net/images/producers/producer-5.jpeg" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "CinemaId", "Description", "EndDateTime", "ImageUrl", "MovieCategory", "Name", "Price", "ProducerId", "StartDateTime" },
                values: new object[,]
                {
                    { 1, 3, "This is the Life movie description", new DateTime(2023, 3, 24, 13, 3, 21, 196, DateTimeKind.Local).AddTicks(2854), "http://dotnethow.net/images/movies/movie-3.jpeg", 6, "Life", 39.5, 3, new DateTime(2023, 3, 4, 13, 3, 21, 196, DateTimeKind.Local).AddTicks(2826) },
                    { 2, 1, "This is the Shawshank Redemption description", new DateTime(2023, 3, 17, 13, 3, 21, 196, DateTimeKind.Local).AddTicks(2896), "http://dotnethow.net/images/movies/movie-1.jpeg", 1, "The Shawshank Redemption", 29.5, 1, new DateTime(2023, 3, 14, 13, 3, 21, 196, DateTimeKind.Local).AddTicks(2895) },
                    { 3, 4, "This is the Ghost movie description", new DateTime(2023, 3, 21, 13, 3, 21, 196, DateTimeKind.Local).AddTicks(2925), "http://dotnethow.net/images/movies/movie-4.jpeg", 7, "Ghost", 39.5, 4, new DateTime(2023, 3, 14, 13, 3, 21, 196, DateTimeKind.Local).AddTicks(2923) },
                    { 4, 1, "This is the Race movie description", new DateTime(2023, 3, 9, 13, 3, 21, 196, DateTimeKind.Local).AddTicks(2951), "http://dotnethow.net/images/movies/movie-6.jpeg", 6, "Race", 39.5, 2, new DateTime(2023, 3, 4, 13, 3, 21, 196, DateTimeKind.Local).AddTicks(2949) },
                    { 5, 1, "This is the Scoob movie description", new DateTime(2023, 3, 12, 13, 3, 21, 196, DateTimeKind.Local).AddTicks(2978), "http://dotnethow.net/images/movies/movie-7.jpeg", 5, "Scoob", 39.5, 3, new DateTime(2023, 3, 4, 13, 3, 21, 196, DateTimeKind.Local).AddTicks(2976) },
                    { 6, 1, "This is the Cold Soles movie description", new DateTime(2023, 4, 3, 13, 3, 21, 196, DateTimeKind.Local).AddTicks(3009), "http://dotnethow.net/images/movies/movie-8.jpeg", 3, "Cold Soles", 39.5, 5, new DateTime(2023, 3, 17, 13, 3, 21, 196, DateTimeKind.Local).AddTicks(3007) }
                });

            migrationBuilder.InsertData(
                table: "ActorMovies",
                columns: new[] { "Id", "ActorId", "MovieId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 3, 1 },
                    { 3, 1, 2 },
                    { 4, 4, 2 },
                    { 5, 1, 3 },
                    { 6, 2, 3 },
                    { 7, 5, 3 },
                    { 8, 2, 4 },
                    { 9, 3, 4 },
                    { 10, 4, 4 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ActorMovies_ActorId",
                table: "ActorMovies",
                column: "ActorId");

            migrationBuilder.CreateIndex(
                name: "IX_ActorMovies_MovieId",
                table: "ActorMovies",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_Movies_CinemaId",
                table: "Movies",
                column: "CinemaId");

            migrationBuilder.CreateIndex(
                name: "IX_Movies_ProducerId",
                table: "Movies",
                column: "ProducerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActorMovies");

            migrationBuilder.DropTable(
                name: "Actors");

            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.DropTable(
                name: "Cinemas");

            migrationBuilder.DropTable(
                name: "Producers");
        }
    }
}
