using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Filter.infrastructure
{
    public class CustomAuthAttribute : AuthorizeAttribute
    {
        private bool localAllowed;

        public CustomAuthAttribute(bool AllowedParam) {
            localAllowed = AllowedParam;
        }

        protected override bool AuthorizeCore(HttpContextBase httpContext) {
            if (httpContext.Request.IsLocal) {
                return localAllowed;
            } else {
                return true;
            }
        }

    }
}