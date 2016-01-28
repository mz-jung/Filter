using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Filter.Controllers
{
    public class GoogleAccountController : Controller
    {
        // GET: GoogleAccount
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string username, string password, string returnURl) {
            if (username.EndsWith("@google.com") && password == "secret") {
                FormsAuthentication.SetAuthCookie(username, false);
                return Redirect(returnURl ?? Url.Action("Index", "Home"));
            } else {
                ModelState.AddModelError("", "Incorrect username, password");
                return View();
            }
        }
    }
}