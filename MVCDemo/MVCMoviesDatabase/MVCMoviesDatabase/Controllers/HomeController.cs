
using MVCMoviesDatabase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCMoviesDatabase.Controllers
{
    public class HomeController : Controller
    {
        private MovieSarahCDataBaseEntities db = new MovieSarahCDataBaseEntities();
        // GET: Home
        public ActionResult Index()
        {
            //LINQ query to get records
            var movies = from m in db.Movies
                         select m;
            return View(movies);
        }
    }
}