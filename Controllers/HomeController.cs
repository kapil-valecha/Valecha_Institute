﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Institute.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        //[CustomAuthorize (Roles ="Admin,Teacher,Student")] //all users
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

          public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        }
}