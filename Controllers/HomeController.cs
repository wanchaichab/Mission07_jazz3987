using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mission06_jazz3987.Models;

namespace Mission06_jazz3987.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private MovieInfoContext movieContext { get; set; }

        public HomeController(ILogger<HomeController> logger, MovieInfoContext x)
        {
            _logger = logger;
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
            return View();
        }

        [HttpPost]
        public IActionResult AddMovie(MovieForm mf)
        {
            movieContext.Add(mf); //add and save data to database
            movieContext.SaveChanges();

            return View("Confirmation"); //show confirmation page
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

