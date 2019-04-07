using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebMVCcap04.Data;
using WebMVCcap04.Models;

namespace WebMVCcap04.Controllers
{
    public class MovieController : Controller
    {
        MovieDbContext db = new MovieDbContext();

        // GET: Movie
        public ActionResult Movie()
        {
            var movies = db.Movies.ToList();
            
            return View(movies);
        }

        public ActionResult Create()
        {
            return View();
        }

        //Post: movie/create
        [HttpPost]
        public ActionResult Create(Movie movie)
        {
            if (ModelState.IsValid)
            {
                var titulo = movie.Title;

                db.Movies.Add(movie);
                db.SaveChanges();

                return RedirectToAction("Movie");
            }

            return View(movie);
        }

       
        public ActionResult Edit(int? id)
        {
            if (id==null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var movie = db.Movies.Find(id);

            if (movie==null)
            {
                HttpNotFound();
            }

            return View(movie);
        }

        [HttpPost]
        public ActionResult Edit(Movie movie)
        {
            if (ModelState.IsValid)
            {
                var titulo = movie.Title;

                db.Entry(movie).State = EntityState.Modified;
                db.SaveChanges();

                return RedirectToAction("Movie");
            }

            return View(movie);
        }

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var movie = db.Movies.Find(id);

            if (movie == null)
            {
                HttpNotFound();
            }

            return View(movie);
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var movie = db.Movies.Find(id);

            if (movie == null)
            {
                HttpNotFound();
            }
            db.Movies.Remove(movie);
            db.SaveChanges();

            return RedirectToAction("Movie");
        }
    }
}