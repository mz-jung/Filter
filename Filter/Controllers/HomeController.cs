//using Filter.infrastructure;
using Filter.Infrastructure;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Filter.Controllers
{
    public class HomeController : Controller
    {
        private Stopwatch timer;

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
        //[ProfileAction] //밑에껏도 안탐. 왜저래. 663page
        //[ProfileResult]
        //[ProfileAll]
        public string FilterTest() { 
            return "This is the FilterTest action";
        }


        /// <summary>
        /// OnActionExecuting
        /// OnResultExecuted
        /// 
        /// 기반(base)클래스가 존재하는 경우 유용하지만
        /// 컨트롤러로직과 필터로직을 분리하는게 좋기때문에 어트리뷰트 방식을 사용하는게 좋다.
        /// </summary>
        /// <param name="filterContext"></param>
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            timer = Stopwatch.StartNew();
        }

        protected override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            timer.Stop();
            filterContext.HttpContext.Response.Write(string.Format("<div>total elapsed time:::: {0:F6}</div>", timer.Elapsed.TotalSeconds));
        }
    }
}
