using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Mission06_jazz3987.Models;

namespace Mission06_jazz3987.Controllers
{
    public class HomeController : Controller
    {
        private MovieInfoContext movieContext { get; set; }

        public HomeController(MovieInfoContext x)
        {
            movieContext = x;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult MyPodcast()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddMovie()
        {
            ViewBag.Category = movieContext.Categories.ToList();
            
            return View();
        }

        [HttpPost]
        public IActionResult AddMovie(MovieForm mf)
        {
            movieContext.Add(mf); //add and save data to database
            movieContext.SaveChanges();

            return View("Confirmation"); //show confirmation page
        }

        public IActionResult ShowMoviesList()
        {
            var movies = movieContext.MovieForms
                .Include(x => x.Category)
                .OrderBy(x => x.Category)
                .ToList();
            return View(movies);
        }
    }
}

