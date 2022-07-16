using eTickets.Data.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{

    public class Actor: IEntityBase
    {

        [Key]
        public int Id { get; set; }




        [Display(Name ="Profile Picture Url")]
        [Required(ErrorMessage ="Pp is required")]
        public string profilePictureURL { get; set; }

        [Display(Name = "Full Name")]
        [Required(ErrorMessage = "full name is required")]
        [StringLength(50,MinimumLength =3,ErrorMessage ="3-20 CHAR")]
        public string fullName { get; set; }

        [Display(Name = "Biography")]
        [Required(ErrorMessage = "bio is required")]
        public string biography { get; set; }

        //releationship

        public List <ActorMovies_IntersactionEntity> Actors_Movies { get; set; }
        }
}
