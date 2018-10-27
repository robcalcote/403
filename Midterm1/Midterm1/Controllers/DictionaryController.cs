using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Midterm1.Controllers
{
    public class DictionaryController : Controller
    {
        // Creates a new static dictionary to be used publicly
        public static Dictionary<int, string> dDictionary = new Dictionary<int, string>();

        // GET: Dictionary
        public ActionResult Index()
        {
            return View();
        }

        // Adds one item and returns "item number #n"
        public ActionResult addOne()
        {
            dDictionary.Add((dDictionary.Count + 1), "item number #" + (dDictionary.Count + 1));

            return View("Index");
        }

        // Adds a huge list of items to the Dictionary
        public ActionResult hugeList()
        {
            // first clears the dictionary of whatever it currently has
            dDictionary.Clear();

            // then adds 2,000 items to the dictionary with a loop
            for (int i = 0; i < 2000; i++)
            {
                dDictionary.Add((dDictionary.Count + 1), "item number #" + (dDictionary.Count + 1));
            }

            return View("Index");
        }

        // Displays what is in the static dictionary thus far.
        public ActionResult displayDictionary()
        {
            if(dDictionary.Count == 0)
            {
                ViewBag.Delete = "The dictionary is empty. Nothing to display.";
            }
            else
            {
                ViewBag.Dictionary = dDictionary;
            }

            return View("Index");
        }

        // Removes 1 item from the dictionary.
        public ActionResult removeDictionary()
        {
            // declare new variable to delete the last key/value pair in the index
            int DictI = dDictionary.Count();

            if (dDictionary.Count == 0)
            {
                ViewBag.Delete = "The dictionary doesn't contain any items, you cannot delete an item! Please add an item before you can delete it";
            }
            else
            {
                dDictionary.Remove(DictI);
            }

            return View("Index");
        }

        // Removes all entries from the dictionary
        public ActionResult clearDictionary()
        {
            dDictionary.Clear();

            return View("Index");
        }

        // This will allow the 
        public ActionResult searchdictionary()
        {
            if (dDictionary.Count == 0)
            {
                ViewBag.Search = "The Dictionary is empty. You must add items before searching the Dictionary.";
            }
            else
            {
                ViewBag.Search = "im not null";
            }
            return View("Index");
        }

        // Posts a form for the user to use to search the dictionary
        // If result is found ViewBag.Searched is called and "Found!" is displayed.
        // otherwise "Not Found." is displayed.
        // In both cases, the time it took to search is also displayed.
        [HttpPost]
        public ActionResult searchDictionary(FormCollection form)
        {
            String searchword = form["Search Here"].ToString();

            // Stopwatch code
                System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();

                sw.Start();

                    //loop to do all the work
                    if (dDictionary.ContainsValue(searchword))
                    {
                        ViewBag.Searched = "Found!";
                    }
                    else if (dDictionary.Count == 0)
                    {
                        ViewBag.Searched = "Dictionary is empty! please add an item before searching!";
                    }
                    else
                    {
                        ViewBag.Searched = "Not Found.";
                    }

                sw.Stop();

                TimeSpan ts = sw.Elapsed;

                ViewBag.StopWatch = "Time Elapsed: ";
                ViewBag.StopWatch = ViewBag.StopWatch + ts;

            return View("Index");
        }
    }
}