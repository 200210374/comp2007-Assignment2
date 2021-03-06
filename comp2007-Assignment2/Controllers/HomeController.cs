﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


//Remember this gets linked to the home folder

namespace comp2007_Assignment2.Controllers
{
  
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact Us";

            return View();
        }

        public ActionResult Menu()
        {
            ViewBag.Message = "Menu-buy stuff.";

            return View();
        }

        public ActionResult MenuItemDetails()
        {
            ViewBag.Message = "Menu";

            return View();
        }

        public ActionResult Home()
        {
            ViewBag.Message = "Home";

            return View();
        }

        public ActionResult HomePage()
        {
            ViewBag.Message = "HomePage";

            return View();
        }




    }
}