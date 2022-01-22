using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using IS413Mission4.Models;

namespace IS413Mission4.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private MovieContext movie { get; set; }

        public HomeController(ILogger<HomeController> logger, MovieContext someName)
        {
            _logger = logger;
            movie = someName;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Podcast()
        {
            return View();
        }

        [HttpGet]
        public IActionResult NewMovie()
        {
            return View();
        }
        [HttpPost]
        public IActionResult NewMovie(ApplicationResponse ar)
        {
            if (ModelState.IsValid)
            {
                if (movie.Responses.Any(a => a.Title.Equals(ar.Title)))
                {
                    return View("Failure", ar);
                }
                movie.Add(ar);
                movie.SaveChanges();
                return View("Confirmation", ar);
            }
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
}
