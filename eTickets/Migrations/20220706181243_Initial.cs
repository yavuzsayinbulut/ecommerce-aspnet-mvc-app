using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eTickets.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Actors",
                columns: table => new
                {
                    actorID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    profilePictureURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    biography = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actors", x => x.actorID);
                });

            migrationBuilder.CreateTable(
                name: "Cinemas",
                columns: table => new
                {
                    cinemaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cinemaLogo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cinemas", x => x.cinemaID);
                });

            migrationBuilder.CreateTable(
                name: "Producers",
                columns: table => new
                {
                    producerID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    profilePictureURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    biography = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Producers", x => x.producerID);
                });

            migrationBuilder.CreateTable(
                name: "Movie",
                columns: table => new
                {
                    movieID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    price = table.Column<double>(type: "float", nullable: false),
                    imageURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    startDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    endDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    category = table.Column<int>(type: "int", nullable: false),
                    CinemaID = table.Column<int>(type: "int", nullable: false),
                    ProducerID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movie", x => x.movieID);
                    table.ForeignKey(
                        name: "FK_Movie_Cinemas_CinemaID",
                        column: x => x.CinemaID,
                        principalTable: "Cinemas",
                        principalColumn: "cinemaID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Movie_Producers_ProducerID",
                        column: x => x.ProducerID,
                        principalTable: "Producers",
                        principalColumn: "producerID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ActorsMovies",
                columns: table => new
                {
                    MovieID = table.Column<int>(type: "int", nullable: false),
                    ActorID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActorsMovies", x => new { x.MovieID, x.ActorID });
                    table.ForeignKey(
                        name: "FK_ActorsMovies_Actors_ActorID",
                        column: x => x.ActorID,
                        principalTable: "Actors",
                        principalColumn: "actorID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ActorsMovies_Movie_MovieID",
                        column: x => x.MovieID,
                        principalTable: "Movie",
                        principalColumn: "movieID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ActorsMovies_ActorID",
                table: "ActorsMovies",
                column: "ActorID");

            migrationBuilder.CreateIndex(
                name: "IX_Movie_CinemaID",
                table: "Movie",
                column: "CinemaID");

            migrationBuilder.CreateIndex(
                name: "IX_Movie_ProducerID",
                table: "Movie",
                column: "ProducerID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActorsMovies");

            migrationBuilder.DropTable(
                name: "Actors");

            migrationBuilder.DropTable(
                name: "Movie");

            migrationBuilder.DropTable(
                name: "Cinemas");

            migrationBuilder.DropTable(
                name: "Producers");
        }
    }
}
