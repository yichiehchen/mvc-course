using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class BascController : Controller
    {
        protected FabricsEntities1 db = new FabricsEntities1();

        protected override void HandleUnknownAction(string actionName)
        {
            if (this.ControllerContext.HttpContext
            .Request.HttpMethod.ToUpper() == "GET")
            {
                this.Redirect("/").ExecuteResult(this.ControllerContext);
            }
            else
            {
                base.HandleUnknownAction(actionName);
            }
        }
    }
}