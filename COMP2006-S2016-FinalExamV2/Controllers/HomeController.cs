/*
    file: controllers/HomeController.cs
    Accepts input and performs backend tasks regarding the Home views
    author: Alex Nicholls
    student number: 200287546
    date: August 18, 2016
    history:
        added controllers and navigation
         added comments
        final commit
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace COMP2006_S2016_FinalExamV2.Controllers
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
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}