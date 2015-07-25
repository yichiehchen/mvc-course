using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.ActionFilter;

namespace WebApplication1.Controllers
{
    public class AFController : Controller
    {
        // GET: AF
        [MyFilter]
        public ActionResult Index()
        {
            System.IO.File.AppendAllText(@"C:\project-0704\MyFilter.log", "#2 AFController.Index()\n");
            throw new Exception("Index failed");
            
            //return Content("OK");
            //return View();
        }

        [OutputCache(Duration=10)]
        public ActionResult TimeCache()
        {
            return View();
        }
    }
}