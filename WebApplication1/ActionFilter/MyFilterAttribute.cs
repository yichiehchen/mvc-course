using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.ActionFilter
{
    public class MyFilterAttribute : ActionFilterAttribute, IExceptionFilter
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            File.AppendAllText(@"C:\project-0704\MyFilter.log", "#1 OnActionExecuting - " + filterContext.RouteData.Values["controller"] + "." + filterContext.RouteData.Values["action"] + "()\n");
            filterContext.Controller.ViewBag.Title = "OKOK";
            base.OnActionExecuting(filterContext);
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            File.AppendAllText(@"C:\project-0704\MyFilter.log", "#3 OnActionExecuted - " + filterContext.RouteData.Values["controller"] + "." + filterContext.RouteData.Values["action"] + "()\n");

            base.OnActionExecuted(filterContext);
        }

        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            File.AppendAllText(@"C:\project-0704\MyFilter.log", "#4 OnResultExecuting - " + filterContext.RouteData.Values["controller"] + "." + filterContext.RouteData.Values["action"] + "()\n");

            base.OnResultExecuting(filterContext);
        }

        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            File.AppendAllText(@"C:\project-0704\MyFilter.log", "#6 OnResultExecuted - " + filterContext.RouteData.Values["controller"] + "." + filterContext.RouteData.Values["action"] + "()\n");

            base.OnResultExecuted(filterContext);
        }

        public void OnException(ExceptionContext filterContext)
        {
            File.AppendAllText(@"C:\project-0704\MyFilter.log", "#7 OnException - " + filterContext.RouteData.Values["controller"] + "." + filterContext.RouteData.Values["action"] + "()\n");
        }
    }
}