using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VideoTutorials.Models
{
    // https://github.com/byu-is-403/syllabus/blob/master/asp-dotnet-mvc/asp-mvc-tutorial.md

    public class GuestResponse
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public bool? WillAttend { get; set; }
    }
}