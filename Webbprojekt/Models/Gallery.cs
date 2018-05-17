using System;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Webbprojekt.Models
{
    public class Gallery
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "Du måste fylla i artsitens namn." )]
        public string ArtistName { get; set; }

        [Required(ErrorMessage = "Du måste lägga till en bild, du är i ett galleri...")]
        public string ImageFile { get; set; }
    }
}