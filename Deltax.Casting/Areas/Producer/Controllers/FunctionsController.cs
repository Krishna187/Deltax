using Deltax.Service.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Deltax.Casting.Areas.Producer.Controllers
{
    public class FunctionsController : Controller
    {
        // GET: Producer/Functions
        public ActionResult Producers()
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                return View(db.Producers.GetAll());
            }
        }

        [HttpPost]
        public ActionResult AddProducer(FormCollection formData)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                db.Producers.AddProducer(new Entity.Domain.Producer
                {
                    name = formData.Get("Name"),
                    Sex = (Entity.Constants.Gender)int.Parse(formData.Get("Sex")),
                    Bio = formData.Get("Bio"),
                    Dob = DateTime.ParseExact(formData.Get("Dob"), "MM/dd/yyyy",
                                  System.Globalization.CultureInfo.InvariantCulture)
                });
                db.SaveChanges();
            }
            return RedirectToAction("Producers", "Functions");
        }
    }
}