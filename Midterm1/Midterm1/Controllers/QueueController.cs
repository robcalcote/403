using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Midterm1.Controllers
{
    public class QueueController : Controller
    {
        // Creates a new static Queue data structure that we can use publicly
        public static Queue<string> myQueue = new Queue<string>();

        // GET: Queue
        public ActionResult Index()
        {
            return View();
        }

        // Enqueue - Adds one item to the end of the queue
        public ActionResult enqueue()
        {
            myQueue.Enqueue("item number #" + (myQueue.Count + 1));

            return View("Index");
        }

        // This will first clear all items from the queue and then add 2000 new items
        public ActionResult hugeList()
        {
            myQueue.Clear();

            for (int i = 0; i < 2000; i++)
            {
                myQueue.Enqueue("item number #" + (myQueue.Count + 1));
            }

            return View("Index");
        }

        // This will display whether the queue has items in it or not
        public ActionResult displayQueue()
        {
            if (myQueue.Count == 0)
            {
                ViewBag.Delete = "The Queue is empty!" +
                    "Please add an item before displaying the Queue";
            }
            else
            {
                ViewBag.Queue = myQueue;
            }

            return View("Index");
        }

        // Dequeue Removes an item from the beginning of the queue
        public ActionResult dequeue()
        {
            if (myQueue.Count == 0)
            {
                ViewBag.Delete = "The Queue is empty!" +
                    "Please add an item before deleting from the Queue";
            }
            else
            {
                myQueue.Dequeue();
            }

            return View("Index");
        }

        // totally clears the queue
        public ActionResult clearQueue()
        {
            myQueue.Clear();

            return View("Index");
        }

        // This will return a value to ViewBag.Search so that the HttpPost can run
        public ActionResult containsQueue()
        {
            if (myQueue.Count == 0)
            {
                ViewBag.Search = "Queue is empty...";
            }
            else
            {
                ViewBag.Search = "Contains items...";
            }

            return View("Index");
        }

        [HttpPost]
        public ActionResult SearchQueue(FormCollection form)
        {
            string searchword = form["Search here"].ToString();
            if (myQueue.Contains(searchword) == true)
            {
                ViewBag.searchresult = "Found!";
            }
            else
            {
                ViewBag.searchresult = "not Found...";
            }

            return View("Index");
        }
    }
}