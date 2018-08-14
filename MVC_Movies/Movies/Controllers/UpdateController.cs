using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Movies.Controllers
{
    public class UpdateController : Controller
    {
        private MVCProjectMovie db = new MVCProjectMovie();
        // GET: Update
        public ActionResult Edit(int? id)
        {
            if(id==null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Movie movie = db.Movies.Find(id);
            if(movie==null)
            {
               return HttpNotFound();
            }
            return View(movie);
        }
    }
}