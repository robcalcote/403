using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VideoTutorials.Models;

// Controller for ASP.NET MVC C# Tutorial video assignment
// https://github.com/byu-is-403/syllabus/blob/master/asp-dotnet-mvc/asp-mvc-tutorial.md

namespace VideoTutorials.Controllers
{
    public class Home1Controller : Controller
    {
        // GET: Home1
        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;

            ViewBag.Greeting = hour < 12 ? "Good Morning" : "Good Afternoon";


            String sTeamName = "Gonzaga";

            ViewBag.Opponent = sTeamName.Equals("Gonzaga") ? "Beat Gonzaga" : "Beat anyone else";

            return View();
        }

        // HTTPGET AND HTTPPOST MUST have the same name, in this case it is RsvpForm
        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }

        [HttpPost]
        public ViewResult RsvpForm(GuestResponse response)
        {
            if(ModelState.IsValid)
            {
                return View("ThankYou", response);
            }
            else
            {
                return View();
            }
        }
    }
}