using Deltax.Service.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Deltax.Casting.Areas.Actor.Controllers
{
    public class FunctionsController : Controller
    {
        // GET: Actor/Functions
        public ActionResult Actors()
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                return View(db.Actors.GetAll());
            }
        }
        [HttpPost]
        public ActionResult AddActor(FormCollection formData)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                db.Actors.AddActor(new Entity.Domain.Actor {
                    name= formData.Get("Name"),
                    Sex = (Entity.Constants.Gender)int.Parse(formData.Get("Sex")),
                    Bio = formData.Get("Bio"),
                    Dob = DateTime.ParseExact(formData.Get("Dob"), "MM/dd/yyyy",
                                  System.Globalization.CultureInfo.InvariantCulture)
            });
                db.SaveChanges();
            }
            return RedirectToAction("Actors", "Functions");
        }
    }
}