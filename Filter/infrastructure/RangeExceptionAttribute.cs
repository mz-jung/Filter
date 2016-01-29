using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Filter.Infrastructure
{
    /// <summary>
    /// .NET 어트리뷰트 클래스를 MVC필터로 동작하도록 만들기 위해서는 클래스가 IMvcFilter 인터페이스를 구현해야만 함.
    /// </summary>
    public class RangeExceptionAttribute: FilterAttribute, IExceptionFilter
    {

        public void OnException(ExceptionContext filterContext)
        {
            if (!filterContext.ExceptionHandled && filterContext.Exception is ArgumentOutOfRangeException)
            {
                //filterContext.Result = new RedirectResult("~/Content/RangeErrorPage.html");
                //filterContext.ExceptionHandled = true;

                int val = (int)(((ArgumentOutOfRangeException)filterContext.Exception).ActualValue);
                filterContext.Result = new ViewResult { ViewName = "RangeError", ViewData = new ViewDataDictionary<int>(val) };
                filterContext.ExceptionHandled = true;
            }

        }
    }
}