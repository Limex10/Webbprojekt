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

        public int ArtistID { get; set; }

        public string ImageFile { get; set; }
    }
}