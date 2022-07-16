using Microsoft.EntityFrameworkCore.Migrations;

namespace eTickets.Migrations
{
    public partial class NameFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ActorsMovies_Movie_MovieID",
                table: "ActorsMovies");

            migrationBuilder.DropForeignKey(
                name: "FK_Movie_Cinemas_CinemaID",
                table: "Movie");

            migrationBuilder.DropForeignKey(
                name: "FK_Movie_Producers_ProducerID",
                table: "Movie");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Movie",
                table: "Movie");

            migrationBuilder.RenameTable(
                name: "Movie",
                newName: "Movies");

            migrationBuilder.RenameIndex(
                name: "IX_Movie_ProducerID",
                table: "Movies",
                newName: "IX_Movies_ProducerID");

            migrationBuilder.RenameIndex(
                name: "IX_Movie_CinemaID",
                table: "Movies",
                newName: "IX_Movies_CinemaID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Movies",
                table: "Movies",
                column: "movieID");

            migrationBuilder.AddForeignKey(
                name: "FK_ActorsMovies_Movies_MovieID",
                table: "ActorsMovies",
                column: "MovieID",
                principalTable: "Movies",
                principalColumn: "movieID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Cinemas_CinemaID",
                table: "Movies",
                column: "CinemaID",
                principalTable: "Cinemas",
                principalColumn: "cinemaID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Producers_ProducerID",
                table: "Movies",
                column: "ProducerID",
                principalTable: "Producers",
                principalColumn: "producerID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ActorsMovies_Movies_MovieID",
                table: "ActorsMovies");

            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Cinemas_CinemaID",
                table: "Movies");

            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Producers_ProducerID",
                table: "Movies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Movies",
                table: "Movies");

            migrationBuilder.RenameTable(
                name: "Movies",
                newName: "Movie");

            migrationBuilder.RenameIndex(
                name: "IX_Movies_ProducerID",
                table: "Movie",
                newName: "IX_Movie_ProducerID");

            migrationBuilder.RenameIndex(
                name: "IX_Movies_CinemaID",
                table: "Movie",
                newName: "IX_Movie_CinemaID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Movie",
                table: "Movie",
                column: "movieID");

            migrationBuilder.AddForeignKey(
                name: "FK_ActorsMovies_Movie_MovieID",
                table: "ActorsMovies",
                column: "MovieID",
                principalTable: "Movie",
                principalColumn: "movieID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Movie_Cinemas_CinemaID",
                table: "Movie",
                column: "CinemaID",
                principalTable: "Cinemas",
                principalColumn: "cinemaID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Movie_Producers_ProducerID",
                table: "Movie",
                column: "ProducerID",
                principalTable: "Producers",
                principalColumn: "producerID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
