/*
 * The HomeController class returns appropriate views to user's requests
 * that display home, 'About', and 'Contacts' web pages, or an error message
 * in case of an error
 * Assignment 1
 * Revision History
 *          Azza Elgendy, Isabela Boudoux, Iryna Shynkevych 2018-09-14 : created
 */
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TeamA.Models;

namespace TeamA.Controllers
{
    public class HomeController : Controller
    {        
        // The default Index action that returns home page view
        public IActionResult Index()
        {
            TempData["message"] = "Hello, puny earthlings";
            return View();
        }

        // About action returns the view with "Your application description page." message on it
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        // Contact action returns the view with "Your contact page." message on it
        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        //Privacy action returns the default view
        public IActionResult Privacy()
        {
            return View();
        }

        // Error view returns the view with an error message
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
