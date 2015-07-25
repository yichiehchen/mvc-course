using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class OrderLinesController : Controller
    {
        private FabricsEntities1 db = new FabricsEntities1();

        // GET: OrderLines
        [ChildActionOnly]
        public ActionResult List(int id)
        {
            var orderLine = db.OrderLine.Where(o => o.ProductId == id).Include(o => o.Order).Include(o => o.Product);
            return View(orderLine.ToList());
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
