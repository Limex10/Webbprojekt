using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Webbprojekt.Models;
using System.Net;
using System.Net.Mail;
using Webbprojekt.Models;
using System.Threading.Tasks;

namespace Webbprojekt.Controllers
{
    public class HomeController : Controller
    {
        private StoreContext db = new StoreContext();

        public ActionResult Index()
        {
            return View(db.Galleries.ToList());
        }
        public ActionResult Contact()
        {
            return View();
        }

    }

}