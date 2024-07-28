using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //ViewData["Message"] = "Jai Shree Ram";
            //ViewData["DateTimes"] = DateTime.Now.ToLongTimeString();

            //string[] fruits = { "Banana", "Apple", "Graps" };
            //ViewData["fruitsarrays"] = fruits;


            //ViewData["SportsList"] = new List<String>()
            //{
            //    "Cricket",
            //    "Football",
            //    "Vollyball",
            //    "Hockey"
            //};


            //ViewBag.message = "Jai Shree Ram";
            //ViewBag.DateTime = DateTime.Now.ToLongTimeString();

            //string[] Color = { "Red", "Yello", "Green" };
            //ViewBag.color = Color;

            //ViewBag.SportsList = new List<string>()
            //{
            //    "Vollay Ball",
            //    "Cricket",
            //    "Kabbadi",
            //    "Tennis Ball"
            //};


            TempData["Message"] = "This is Temp Data";
            
            return View();
            
        }

        public ActionResult About()
        {
            return View();
        }
    }
}