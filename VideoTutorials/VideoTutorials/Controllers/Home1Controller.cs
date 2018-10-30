using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

// Controller for ASP.NET MVC C# Tutorial video assignment

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
    }
}