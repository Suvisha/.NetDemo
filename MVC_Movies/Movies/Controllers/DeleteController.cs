using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Movies.Controllers
{
    public class DeleteController : Controller
    {
        private MVCProjectMovie db = new MVCProjectMovie();
        // GET: Delete
        public ActionResult Delete(int? id)
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
        //POST: Delete
        [HttpPost,ActionName("Delete")]
        public ActionResult DeleteConformed(int id)
        {
            Movie movie = db.Movies.Find(id);
            db.Movies.Remove(movie);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}