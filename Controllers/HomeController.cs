using CIS174.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CIS174.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }

    public class StudentPageController : Controller
    {
        [Route("Assignment/{id?}")]
        public IActionResult Index(int id = 1)
        {
            ViewBag.ValueID = id;

            List <Student> students = new List<Student>();
                students.Add(new Student("Michelle", "Alexander", "7th"));
                students.Add(new Student("Stephen E.", "Ambrose", "6th"));
                students.Add(new Student("Margaret", "Atwood", "11th"));
                students.Add(new Student("Jane", "Austen", "12th"));
                students.Add(new Student("James", "Baldwin", "10th"));
            
                
            return View("Index", students);
        }
    }
}
