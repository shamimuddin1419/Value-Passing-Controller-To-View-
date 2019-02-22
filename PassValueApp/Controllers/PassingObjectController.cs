using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PassValueApp.Models;

namespace PassValueApp.Controllers
{
    public class PassingObjectController : Controller
    {
        public IActionResult Index()
        {
            Student student = new Student
            {

                ID = 1,
                Name = "Siam",
                Roll = "101-14-001",
                Email = "Siam@gmail.com"
            };
            return View(student);
        }
    }
}