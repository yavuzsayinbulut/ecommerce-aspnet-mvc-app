using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Producer
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int producerID { get; set; }

        [Display(Name = "Profile Photo")]     
        public string profilePictureURL { get; set; }
        [Display(Name = " Full Name")]
        public string fullName { get; set; }
        [Display(Name = " Biography")]
        public string biography { get; set; }

        //relationship

        public List<Movie> Movies { get; set; }
    }
}
