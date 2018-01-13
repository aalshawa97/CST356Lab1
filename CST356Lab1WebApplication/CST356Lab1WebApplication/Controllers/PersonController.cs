using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CST356Lab1WebApplication.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult WelcomePerson()
        {
            ViewBag.Message = "Welcome person to CST 356 Lab1";

            return View();
        }
    }
}