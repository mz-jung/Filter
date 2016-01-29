using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Filter.Infrastructure
{
    public class CustomActionAttribute: FilterAttribute, IActionFilter
    {
        /// <summary>
        /// 액션 메서드가 불려지기 전 호출되는 메서드
        /// </summary>
        /// <param name="filterContext">ControllerContext 하위 클래스</param>
        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (filterContext.HttpContext.Request.IsLocal)
            {
                filterContext.Result = new HttpNotFoundResult();
            }
        }
        /// <summary>
        /// 액션 메서드가 불려진 후 호출되는 메서드
        /// </summary>
        /// <param name="filterContext">ControllerContext 하위 클래스</param>
        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            //
        }
    }
}