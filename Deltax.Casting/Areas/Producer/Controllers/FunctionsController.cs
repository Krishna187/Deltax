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
                return View(db.Producer.GetAll());
            }
        }
    }
}