using System.Collections.Generic;

namespace eTickets.Models
{
    public class Cinema
    {
        [System.ComponentModel.DataAnnotations.Key]

        public int Id { get; set; }
        public string cinemaLogo { get; set; }
        public string name { get; set; }
        public string description { get; set; }


        //relationship

        public List<Movie> Movies { get; set; }
    }
}
