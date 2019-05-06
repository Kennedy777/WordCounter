using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using WordCounter;

namespace WordCounter.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost("/checkword")]
        public ActionResult CheckWord()
        {
            return View();
        }
    }
}
