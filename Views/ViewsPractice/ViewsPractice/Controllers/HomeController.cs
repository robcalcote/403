using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ViewsPractice.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            int hour = DateTime.Now.Hour;

            ViewBag.Greeting = hour < 12 ? "Good Morning" : "Good Afternoon";

            return View();
        }

        // Action method to create and display RSVP form
        public ViewResult RsvpForm()
        {
            return View();
        }

        // This method will redirect to www.ksl.com
        public ActionResult KSL()
        {
            return new RedirectResult("http://www.ksl.com");
        }
    }
}