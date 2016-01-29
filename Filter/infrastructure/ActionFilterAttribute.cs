using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Filter.infrastructure
{
    public abstract class ActionFilterAttribute: FilterAttribute, IActionFilter, IResultFilter
    {
        public virtual void OnActionExecuted(ActionExecutedContext filterContext)
        {
            //throw new NotImplementedException();
        }

        public virtual void OnActionExecuting(ActionExecutingContext filterContext)
        {
            //throw new NotImplementedException();
        }

        public virtual void OnResultExecuted(ResultExecutedContext filterContext)
        {
            //throw new NotImplementedException();
        }

        public virtual void OnResultExecuting(ResultExecutingContext filterContext)
        {
            //throw new NotImplementedException();
        }
    }
}