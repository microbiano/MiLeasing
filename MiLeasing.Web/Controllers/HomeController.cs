using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MiLeasing.Web.Models;

namespace MiLeasing.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

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


//Todo:https://www.youtube.com/watch?v=CdYQP06xco0&list=PLuEZQoW9bRnRkiC9j5XkMVphyWkz0cdRk&index=3
//Todo:https://www.youtube.com/watch?v=fr91VdOqOMY&list=PLuEZQoW9bRnRkiC9j5XkMVphyWkz0cdRk&index=9
//Todo:https://www.youtube.com/watch?v=gKJw0J2NV0A&list=PLuEZQoW9bRnRkiC9j5XkMVphyWkz0cdRk&index=15