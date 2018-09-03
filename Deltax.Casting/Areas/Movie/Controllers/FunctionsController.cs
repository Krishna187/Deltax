using Deltax.Service.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Deltax.Casting.Areas.Movie.Controllers
{
    public class FunctionsController : Controller
    {

        // GET: Movie/Functions
        public ActionResult Movies()
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                ViewBag.Producers = db.Producers.GetAllProducers();
                ViewBag.Producers = db.Producers.GetAllProducers();
                return View(db.Movies.GetAllMovies());
            }
        }

        public ActionResult AddMovie(FormCollection formData)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                var actorsId = formData.Get("ActorsId").Split(',');
                var actors = new List<Entity.Domain.Actor>();
                foreach(var actorId in actorsId)
                {
                    actors.Add(db.Actors.GetByID(actorId) as Entity.Domain.Actor);
                }

                var movie = new Entity.Domain.Movie
                {
                    MovieName = formData.Get("Name"),
                    Plot = formData.Get("Plot"),
                    Producer = db.Producers.GetByID(formData.Get("ProducerId")) as Entity.Domain.Producer,
                    Actors = actors
                };

                db.Movies.Add(movie);
                return RedirectToAction("Movies");
            }
        }
    }
}