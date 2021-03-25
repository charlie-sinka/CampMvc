using LagerMVC.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CampMvc.Controllers
{
    public class AdminController : Controller
    {
        CampContext db;
        public AdminController(CampContext context)
        {
            db = context;
        }

        [Authorize(Roles = "admin")]
        [HttpGet]
        public ActionResult Index()
        {
            ViewBag.Vouch = db.Vouchers.ToList();
            return View(db.Orders);
        }
    }
}
