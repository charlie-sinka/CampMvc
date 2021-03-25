using CampMvc.Models;
using LagerMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CampMvc.Controllers
{
    public class HomeController : Controller
    {
       CampContext db;

        public HomeController(CampContext context)
        {
            db = context;
        }

        public IActionResult Index()
        {
            return View(db.Vouchers.ToList());
        }

        public IActionResult Contacts()
        {
            return View();
        }
    }
}
