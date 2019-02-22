using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PassValueApp.Controllers
{
    public class PassingDataController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.ID = 1;
            ViewBag.Name = "Siam";
            ViewBag.Roll = "101-14-001";
            ViewBag.Email = "Siam@gmail.gmail.com";
            return View();
        }
    }
}