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

        //[RangeException]
        [HandleError(ExceptionType = typeof(ArgumentOutOfRangeException), View = "RangeError")]
        public string RangeTest(int id) {
            if (id > 100) {
                return String.Format("The id value is : {0}", id);
            } else {
                throw new ArgumentOutOfRangeException("id", id, "");                    
            }
        }

        //[CustomAction] //CustomAction 안먹는데? 왜저래. 404안나옴.
        [ProfileAction] //밑에껏도 안탐. 왜저래. 663page
        public string FilterTest() { 
            return "This is the FilterTest action";
        }
    }
}
