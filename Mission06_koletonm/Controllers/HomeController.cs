using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mission06_koletonm.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mission06_koletonm.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private Mission6Context MyContext { get; set; }

        public HomeController(ILogger<HomeController> logger, Mission6Context x)
        {
            _logger = logger;
            MyContext = x;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult MyPodcasts()
        {
            return View();
        }
        public IActionResult Confirmation()
        {
            return View();
        }
        [HttpGet]
        public IActionResult AddMovie()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddMovie(AddMovieResponse amr)
        {
            MyContext.Add(amr);
            MyContext.SaveChanges();
            return View("Confirmation");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
