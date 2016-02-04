using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PLAYnGO_TestProject.Models;

namespace PLAYnGO_TestProject.Controllers
{
    public class ProfileController : Controller
    {
        DatabaseContext db = new DatabaseContext();

        public ActionResult Index()
        {
            ViewBag.profilelist = (from p in db.Profiles
                                   select p).ToList();
            return View();
        }

    }
}
