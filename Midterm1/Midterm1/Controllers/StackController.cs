using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Midterm1.Controllers
{
    public class StackController : Controller
    {
        // Creates a new static stack to be used publicly
        public static Stack<string> myStack = new Stack<string>();

        // GET: Stack
        public ActionResult Index()
        {
            return View("Index");
        }
        
        // This method will add one item to the top of the stack
        public ActionResult addOne()
        {
            myStack.Push("Item Number #" + (myStack.Count + 1));

            return View("Index");
        }

        // This method will first clear the stack, then add 2000 items to the stack
        public ActionResult hugeList()
        {
            myStack.Clear();

            for (int i = 0; i < 2000; i++)
            {
                myStack.Push("New Entry #" + (myStack.Count + 1));
            }

            return View("Index");
        }

        // This method will return the stack
        public ActionResult displayStack()
        {
            if (myStack.Count == 0)
            {
                ViewBag.Delete = "The Stack is empty, please add an item before displaying stack!";
            }
            else
            {
                ViewBag.Stack = myStack;
            }

            return View("Index");
        }
        
        // This method will remove one item from the top of the stack
        public ActionResult popStack()
        {
            if (myStack.Count == 0)
            {
                ViewBag.Delete = "The Stack is empty, please add an item before deleting from stack!";
            }
            else
            {
                myStack.Pop();
                ViewBag.Delete = "1 item deleted from stack.";
            }

            return View("Index");
        }
        
        // This method will completely clear all items off of the stack
        public ActionResult clearStack()
        {
            myStack.Clear();

            return View("Index");
        }
    
        // This method will post in the form whether there is something in the dictionary or not
        public ActionResult searchStack()
        {
            if (myStack.Count == 0)
            {
                ViewBag.Search = "Contains Nothing...";
            }
            else
            {
                ViewBag.Search = "Search Now:";
            }

            return View("Index");
        }

        [HttpPost]
        public ActionResult SearchStack(FormCollection form)
        {
            string search = Request.Form["search"];

            // Stopwatch code
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();

            sw.Start();

                //loop to do all the work
                if (myStack.Contains(search))
                {
                    ViewBag.Searched = "Found!";
                }
                else if (myStack.Count == 0)
                {
                    ViewBag.Searched = "Stack is empty! please add an item before searching!";
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