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
                return View(db.Movies.GetAll());
            }
        }
    }
}