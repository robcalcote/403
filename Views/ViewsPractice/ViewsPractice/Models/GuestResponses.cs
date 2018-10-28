using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ViewsPractice.Models
{
    public class GuestResponses
    {
        public string sName { get; set; }
        public string sEmail { get; set; }
        public string sPhone { get; set; }
        // ? on the end of bool allows you to store, true, false or null.
        public bool? bWillAttend { get; set; }
    }
}