using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ViewsPractice.Models
{
    public class GuestResponses
    {
        [Required(ErrorMessage = "Please enter your name")]
        public string sName { get; set; }

        [Required(ErrorMessage = "Please enter your email address")]
        public string sEmail { get; set; }

        [Required(ErrorMessage = "Please enter your phone number")]
        public string sPhone { get; set; }

        [Required(ErrorMessage = "Please specify if you will attend")]
        // ? on the end of bool allows you to store, true, false or null.
        public bool? bWillAttend { get; set; }
    }
}