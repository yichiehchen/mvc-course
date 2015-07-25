using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class FormController : Controller
    {
        // GET: Form
        public ActionResult Index()
        {
            //ModelState 對應強行別資料，可承接上一頁資料，優先權較高 //ViewData 對應弱型別資料
            //ModelState.Clear();
            ViewData["Name"] = "Jhon";
            return View();
        }

        [HttpPost]
        public ActionResult Index(SampleVM data)
        {
            data.Name = "123";
            ViewData["Name"] = "Jhon-Mary";
            return View(data);
        }
    }
}