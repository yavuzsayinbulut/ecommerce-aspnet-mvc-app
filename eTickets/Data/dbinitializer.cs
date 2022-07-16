using eTickets.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Linq;

namespace eTickets.Data
{
    public class dbinitializer
    {
       
            public static void Seed(IApplicationBuilder applicationBuilder)
            {
                using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())

                {
                    var context = serviceScope.ServiceProvider.GetService<dbContextFile>();
                    context.Database.EnsureCreated();

                    //Cinema
                    if (!context.Cinemas.Any())
                    {
                      context.Cinemas.AddRange(new List<Cinema>()
                            
                      {
                          new Cinema() { cinemaLogo="a",description="b",name="c"},
                            new Cinema() { cinemaLogo="a1",description="b1",name="c1"}

                      }
                      );
                    context.SaveChanges();
                }
                   
                    //Actor
                    if (!context.Actors.Any())
                    {

                    context.Actors.AddRange(new List<Actor>()
                    { new Actor()
                    {
                        fullName="aa",biography="bb",profilePictureURL="cc"
                    }
                    });
                    context.SaveChanges();
                    }
                   
                    //Producer
                    if (!context.Producers.Any())
                    {
                    context.Producers.AddRange( new List<Producer>
                    { new Producer(){fullName="aaa",biography="bbb",profilePictureURL="ccc"}});
                    context.SaveChanges();

                    }
                    //Movies
                    if (!context.Movies.Any())
                {
                    context.Movies.AddRange(new List<Movie>
                    { new Movie(){name="aaaa",category=@enum.MovieCategory.Action,price=2}});
                    context.SaveChanges();

                }
                    //actor and movies
                    if (!context.ActorsMovies.Any())
                    {
                    context.ActorsMovies.AddRange(new List<ActorMovies_IntersactionEntity>()

                      {
                          new ActorMovies_IntersactionEntity() { ActorID=1,MovieID=1},
                          

                      }
                    );
                    context.SaveChanges();
                }

                }
            }
        
    }
}
