using LagerMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CampMvc.Controllers
{
    public class OrderController : Controller
    {
        CampContext db;

        public OrderController(CampContext context)
        {
            db = context;
        }

        [HttpGet]
        public ActionResult Index(int? id)
        {
            ViewBag.VoucherId = id;
            return View(db.Vouchers.ToList());
        }

        [HttpPost]
        public ActionResult Index(Order order)
        {
            db.Orders.Add(order);
            db.SaveChanges();
            return View("Thanks");
        }
    }
}
