using NetMVC001.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NetMVC001.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Join()
        {
            return View();
        }
        [HttpPost]
        public ActionResult join(CUser aUser)
        {
            return View(aUser);
        }

    }
}