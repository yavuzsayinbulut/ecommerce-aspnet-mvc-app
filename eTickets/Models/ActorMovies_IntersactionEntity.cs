﻿namespace eTickets.Models
{
    public class ActorMovies_IntersactionEntity
    {
        public int MovieID { get; set; }
        public Movie Movie { get; set; }

        public int ActorID { get; set; }
        public Actor Actor { get; set; }
    }
}
