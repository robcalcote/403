using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Midterm1.Controllers
{
    public class IndexController : Controller
    {
        // GET: Index
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ExitApp()
        {
            return Redirect("https://www.byu.edu");
        }
    }
}