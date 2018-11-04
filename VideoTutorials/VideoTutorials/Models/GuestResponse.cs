using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VideoTutorials.Models
{
    // https://github.com/byu-is-403/syllabus/blob/master/asp-dotnet-mvc/asp-mvc-tutorial.md

    public class GuestResponse
    {
        [Required(ErrorMessage = "Please enter a name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter an email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter a phone number")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Please indicate if you will attend")]
        public bool? WillAttend { get; set; }
    }
}