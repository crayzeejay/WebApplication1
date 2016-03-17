using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class RoutesDemoController : Controller
    {
        // GET: RoutesDemo
        public ActionResult One()
        {
            return View();
        }

        public ActionResult Two(int donuts = 1)
        {
            ViewBag.Donuts = donuts;
            return View();
        }

        [Authorize]
        public ActionResult Three()
        {
            Models.DB1Entities1 e = new DB1Entities1();
            var result = e.Movies.ToList();
            ViewBag.Movies = result;
            return View();
        }


        public ActionResult Four()
        {
            return View();
        }
    }
}