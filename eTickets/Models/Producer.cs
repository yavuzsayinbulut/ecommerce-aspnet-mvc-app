﻿using eTickets.Data.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Producer:IEntityBase  //producerserviceden gelip Entity Interface base i import ettik
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int Id { get; set; }

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
