using eTickets.Models;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Data
{
    public class dbContextFile : DbContext
    {
        //ctor constructor

        public dbContextFile(DbContextOptions<dbContextFile> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ActorMovies_IntersactionEntity>().HasKey(am => new
            {
                am.MovieID,
                am.ActorID,
            });


            modelBuilder.Entity<ActorMovies_IntersactionEntity>().HasOne(m => m.Movie).
                WithMany(am => am.Actor_Movies).HasForeignKey(m => m.MovieID);

            modelBuilder.Entity<ActorMovies_IntersactionEntity>().HasOne(m => m.Actor).
                WithMany(am => am.Actors_Movies).HasForeignKey(m => m.ActorID);



            base.OnModelCreating(modelBuilder);

        }

        public DbSet<Actor> Actors { get; set; }
        public DbSet<Cinema> Cinemas { get; set; }
        public DbSet<ActorMovies_IntersactionEntity> ActorsMovies { get; set; }
        public DbSet<Producer> Producers { get; set; }
        public DbSet<Movie> Movies { get; set; }
    }
}
