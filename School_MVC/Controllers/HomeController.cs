using Microsoft.AspNetCore.Mvc;
using School_MVC.Data;
using School_MVC.Models;
using School_MVC.Services;
using System.Diagnostics;

namespace School_MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISchoolInterface _inter;
        
        private static List<School> _schools = new List<School>
        {
            new School
            {
                Id = Guid.NewGuid(),
                Name = "Xojiakbar",
                LastName = "Madaminov",
                Course = "C#"
            }
        };
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(School request)
        {
            _inter.Add(request);
            return RedirectToAction("Index");
        }
    }
}