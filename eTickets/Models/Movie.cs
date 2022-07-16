using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace eTickets.Models
{
    public class Movie
    {
        [System.ComponentModel.DataAnnotations.Key]

        public int movieID { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public double price { get; set; }
        public string imageURL { get; set; }

        public System.DateTime startDate { get; set; }
        public System.DateTime endDate { get; set; }

        public Data.@enum.MovieCategory category { get; set; }

        //releationship
        public List<ActorMovies_IntersactionEntity> Actor_Movies{ get; set; }

        //cinema
        public int CinemaID { get; set; }
      //  [ForeignKey("cinemaID")] 
        public Cinema Cinema { get; set; }

        //producer
        public int ProducerID { get; set; }
      //  [ForeignKey("producerID")]
        public Producer Producer { get; set; }
    }
}
