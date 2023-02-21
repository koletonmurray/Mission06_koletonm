using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        private Mission6Context MyContext { get; set; }

        public HomeController(Mission6Context x)
        {
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
            ViewBag.MovieCategories = MyContext.MovieCategories.ToList();

            return View();
        }
        [HttpPost]
        public IActionResult AddMovie(AddMovie am)
        {
            // If there aren't valid inputs then return the same page and it will display the validation errors
            if (!ModelState.IsValid)
            {
                return View("AddMovie");
            }

           MyContext.Add(am);
           MyContext.SaveChanges();
           return View("Confirmation");

        }
        public IActionResult ShowMovies()
        {
            var movie = MyContext.Movies.Include(m => m.MovieCategory).OrderBy(m => m.MovieCategory).ToList();
            return View(movie);
        }
    }
}
