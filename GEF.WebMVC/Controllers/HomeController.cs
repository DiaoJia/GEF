using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using GEF.WebMVC.Models;
using System;

namespace GEF.WebMVC.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            var hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Good Morning" : "Good Afternoon";
            return View("MyView");
        }

        public ViewResult RsvpForm()
        {
            return View();
        }

    }
}
