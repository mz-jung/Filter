//using Filter.infrastructure;
using Filter.infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Filter.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        //[CustomAuth(false)]
        [Authorize(Users = "admin")]
        public String Index()
        {
            return "go Filter studyyy";
        }

        [GoogleAuth]
        [Authorize(Users = "jung@google.com")]
        public string List() {
            return "google";
        }
    }
}