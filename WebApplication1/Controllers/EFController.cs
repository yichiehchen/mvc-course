using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class EFController : Controller
    {
        FabricsEntities1 db = new FabricsEntities1();

        // GET: EF
        public ActionResult Index()
        {
            var data = db.Product.Where(p => p.ProductId > 1500);

            return View(data);
        }

        public int AddProduct()
        {
            var product = new Product()
            {
                ProductName = "T-shirt",
                Active = true,
                Price = 100,
                Stock = 10
            };

            db.Product.Add(product);

            db.SaveChanges();

            return product.ProductId;

            return 0;
        }

        public ActionResult RemoveClient()
        {
            var clients = db.Client.Take(5);

            foreach (var client in clients)
            {
                foreach(var order in client.Order)
                {
                    db.OrderLine.RemoveRange(order.OrderLine);
                }
                db.Order.RemoveRange(client.Order);
            }

            db.Client.RemoveRange(clients);

            db.SaveChanges();

            return View(clients);
        }

        public ActionResult UpdateClient()
        {
            var data = db.Client.Take(5);

            foreach (var item in data)
            {
                item.City = "Taipei";
            }

            db.SaveChanges();

            return View(data);
        }

        public ActionResult vwClientOrder()
        {
            return View(db.vwClientOrder.Take(5));
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        public ActionResult PartialViewTest()
        {
            return PartialView("MyPartial");
        }
       
    }
}