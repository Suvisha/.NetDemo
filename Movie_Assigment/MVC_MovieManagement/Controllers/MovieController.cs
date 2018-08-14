using MVC_MovieManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace MVC_MovieManagement.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        public ActionResult Index()
        {
            MovieDbHandler dbhandle = new MovieDbHandler();
            ModelState.Clear();
            return View(dbhandle.GetMovie());
        }

        // GET: Movie/Details/5
        public ActionResult Details(int? id)
        {
            if(id==null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MovieDbHandler mdb = new MovieDbHandler();
            
            if(mdb.GetMovie()==null)
            {
                return HttpNotFound();
            }
            return View(mdb.GetMovie());
        }

        // GET: Movie/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Movie/Create
        [HttpPost]
        public ActionResult Create(Movie Movie)
        {
            try
            {
                // TODO: Add insert logic here
                if (ModelState.IsValid)
                {
                    MovieDbHandler mdb = new MovieDbHandler();
                    if (mdb.AddMovie(Movie))
                    {
                        ViewBag.Message = "Movie Added Successfully";
                        ModelState.Clear();
                    }
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Movie/Edit/5
        public ActionResult Edit(int id)
        {
            MovieDbHandler mdb = new MovieDbHandler();
            return View(mdb.GetMovie().Find(Movie => Movie.MovieId == id));
        }

        // POST: Movie/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Movie movie)
        {
            try
            {
                // TODO: Add update logic here
                MovieDbHandler mdb = new MovieDbHandler();
                mdb.UpdateMovie(movie);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Movie/Delete/5
        public ActionResult Delete(int id)
        {
            try
            {
                // TODO: Add delete logic here
                MovieDbHandler mdb = new MovieDbHandler();
                if (mdb.DeleteMovie(id))
                {
                    ViewBag.AlertMsg = "Movie Deleted Successfully";
                }
                return RedirectToAction("Index");

            }
            catch
            {
                return View();
            }
        }

        //// POST: Movie/Delete/5
        //[HttpPost]
        //public ActionResult Delete(int id)
        //{
        //    try
        //    {
        //        // TODO: Add delete logic here
        //        MovieDbHandler mdb = new MovieDbHandler();
        //        if (mdb.DeleteMovie(id))
        //        {
        //            ViewBag.AlertMsg = "Movie Deleted Successfully";
        //        }
        //        return RedirectToAction("Index");
               
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
