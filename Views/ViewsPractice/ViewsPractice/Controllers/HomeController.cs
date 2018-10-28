using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewsPractice.Models;

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
        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }

        [HttpPost]
        public ViewResult RsvpForm(GuestResponses guestResponses)
        {
            if (ModelState.IsValid)
            {
                return View("Thanks", guestResponses);
            }
            else
            {
                //In Case of a validation Error
                return View("RsvpForm");
            }

        }

        // This method will redirect to www.ksl.com
        public ActionResult KSL()
        {
            return new RedirectResult("http://www.ksl.com");
        }
    }
}