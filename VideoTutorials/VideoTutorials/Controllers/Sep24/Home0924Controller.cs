using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VideoTutorials.Controllers.Sep24
{
    public class Home0924Controller : Controller
    {
        // GET: Home
        public ActionResult Sep24()
        {
            // Generate a random Number
            Random oRand = new Random();
            int[] aiNumber = new int[5];


            // Load up all indexes of array with a number between 1-12
            aiNumber[0] = oRand.Next(1, 13);
            aiNumber[1] = oRand.Next(1, 13);
            aiNumber[2] = oRand.Next(1, 13);
            aiNumber[3] = oRand.Next(1, 13);
            aiNumber[4] = oRand.Next(1, 13);

            // Loop (array length long) to display all numbers to the ViewBag.ArrayContents
            for (int i = 0; i < aiNumber.Length; i++)
            {
                ViewBag.ArrayContents += "<p>" + aiNumber[i] + "</p></br>";
            }

            // Return View
            return View();
        }
    }
}