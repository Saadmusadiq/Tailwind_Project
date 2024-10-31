using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Tailwind_Project.Models;

namespace Tailwind_Project.Controllers
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
            return View("Partials/Dashboard");

            
        }
        public IActionResult Calender()
        {
            return View();
        }
        public IActionResult Profile()
        {
            return View();  
        }


        public IActionResult Privacy()
        {
            return View();
        
        }
/*
        public IActionResult Dashboard()
        {
            return View("Partials/Charts-01");
        }*/   

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
