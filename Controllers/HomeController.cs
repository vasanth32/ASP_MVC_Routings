using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Routings.Controllers
{
    public class HomeController : Controller
    {
        // Optional URI Parameter
        // URL: /MVCTest/
        // URL: /MVCTest/Pranaya
        [Route("MVCTest/{studentName ?}")]
        [HttpGet]
        public ActionResult MVC(string studentName)
        {

            ViewBag.Message = "Welcome to ASP.NET MVC!";
            return View();
        }
        // Optional URI Parameter with default value
        // URL: /WEBAPITest/
        // URL: /WEBAPITest/Pranaya
        [Route("WEBAPITest/{studentName = Pranaya}")]
        [HttpGet]
        public ActionResult WEBAPI(string studentName)
        {
            ViewBag.Message = "Welcome to ASP.NET WEB API!";
            return View();
        }
    }
}