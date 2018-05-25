using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Webbprojekt.Models;

namespace Webbprojekt.Controllers
{
    public class HomeController : Controller
    {
        private StoreContext db = new StoreContext();

        public ActionResult Index()
        {
            //var tupleModel = new Tuple<List<Artist>, List<Gallery>>(db.Artists.ToList(), db.Galleries.ToList());

            ArtistGalleryModels model = new ArtistGalleryModels();

            model.Artists = db.Artists.ToList();
            model.Galleries = db.Galleries.ToList();

            return View(model);
        }


    }
}