using System;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Webbprojekt.Models
{
    public class Artist
    {

        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "Du måste fylla i artistens namn..")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Fyll i artistens Twitter..")]
        public string TwitterLink { get; set; }

        [Required(ErrorMessage = "Fyll i artistens Facebook..")]
        public string FacebookLink { get; set; }

        [Required(ErrorMessage = "Fyll i artistens Instagram..")]
        public string InstagramLink { get; set; }

        public string ImageFile { get; set; }

    }
}