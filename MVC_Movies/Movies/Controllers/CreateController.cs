using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Movies.Controllers
{
    public class CreateController : Controller
    {
        private MVCProjectMovie db = new MVCProjectMovie();
        // GET: Create
        public ActionResult Create()
        {
            return View();
        }
        //POST: Create
        [HttpPost]
        public ActionResult Create([Bind(Include="MovieId,MovieName,MovieDetails")] Movie Movie)
        {
            if(ModelState.IsValid)
            {
                db.Movies.Add(Movie);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(Movie);
        }
    }
}