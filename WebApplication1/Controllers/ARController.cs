using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class ARController : Controller
    {
        // GET: AR
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult PartialViewTest()
        {
            return PartialView("MyPartial");
        }

        public FileResult FileTest()
        {
            return File(Server.MapPath("~/Content/ZENFONE.png"), "image/png", "ZenFone.png");
        }
    }
}