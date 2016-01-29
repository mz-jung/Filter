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
            return "go Filter study";
        }

        [GoogleAuth]
        [Authorize(Users = "user@google.com")]
        public string List() {
            return "google";
        }

        [RangeException]
        public string RangeTest(int id) {
            if (id > 100) {
                return String.Format("The id value is : {0}", id);
            } else {
                throw new ArgumentOutOfRangeException("id", id, "");                    
            }
        }
    }
}