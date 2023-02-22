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
            if (ModelState.IsValid) //Validate data
            {
                movieContext.Add(mf); //add and save data to database
                movieContext.SaveChanges();

                return View("Confirmation", mf); //show confirmation page
            }

            else
            {
                ViewBag.Category = movieContext.Categories.ToList();
                return View();
            }
            
        }

        public IActionResult ShowMoviesList()
        {
            var movies = movieContext.MovieForms
                .Include(x => x.Category)
                .OrderBy(x => x.Category)
                .ToList();
            return View(movies);
        }

        [HttpGet]
        public IActionResult Edit(int movieid)
        {
            ViewBag.Category = movieContext.Categories.ToList();

            var movie = movieContext.MovieForms.Single(x => x.MovieId == movieid); // Get id of movie from edit link

            return View("AddMovie", movie);
        }

        [HttpPost]
        public IActionResult Edit(MovieForm mf)
        {
            movieContext.Update(mf);
            movieContext.SaveChanges();

            return RedirectToAction("ShowMoviesList");
        }

        [HttpGet]
        public IActionResult Delete(int movieid)
        {
            var movie = movieContext.MovieForms.Single(x => x.MovieId == movieid);
            return View(movie);
        }

        [HttpPost]
        public IActionResult Delete(MovieForm mf)
        {
            movieContext.MovieForms.Remove(mf);
            movieContext.SaveChanges();

            return RedirectToAction("ShowMoviesList");
        }
    }
}

