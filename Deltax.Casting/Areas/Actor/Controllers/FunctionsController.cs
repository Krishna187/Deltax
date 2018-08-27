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
                db.Actors.Add(new Entity.Domain.Actor {
                    User = new Entity.Domain.User {
                        Name = formData.Get("Name"),
                        Bio = formData.Get("Bio"),
                        Sex = (Entity.Constants.Gender)(int.Parse(formData.Get("Sex"))),
                        Dob = DateTime.ParseExact(formData.Get("Dob"), "DD/MM/yyyy", )
                    },
                });

            }
            return RedirectToAction("Actors", "Functions");
        }
    }
}