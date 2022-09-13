using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvcFirst.Models;

namespace mvcFirst.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            user user = new user();
            user.ID = 1;
            user.FirstName = "Maher";
            user.LastName = "Dakdouk";
            user.Age = 25;
            return View(user);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}