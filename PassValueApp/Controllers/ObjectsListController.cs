using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PassValueApp.Models;

namespace PassValueApp.Controllers
{
    public class ObjectsListController : Controller
    {
        public IActionResult Index()
        {
            List<Student> students = new List<Student>() {
                new Student{ID=1, Roll="101-14-001",Name="Siam",Email="Siam@gmail.com"},
                new Student{ID=2, Roll="101-14-002",Name="Mohibul",Email="Mohibul@gmail.com"},
                new Student{ID=3, Roll="101-14-003",Name="Ripon",Email="Ripon@gmail.com"}

            };

           return View(students);
        }
    }
}