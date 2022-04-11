using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gurmeet10.Controllers
{
    public class gurmeetController : Controller
    {
        public IActionResult abc()
        {
            ViewBag.text = "gurmeet";
            ViewBag.text1 = 963400;
            ViewBag.text2 = 45.25;
            ViewBag.text3 = DateTime.Now;

            ViewData["text"] = "gurmeet";
            ViewData["text1"] = 1000;
            ViewData["text2"] = 78.25;
            ViewData["text3"] = DateTime.Now;

            TempData["text"] = "gurmeet";
            TempData["text1"] = 7800;
            TempData["text2"] = 10.2;
            TempData["text3"] = DateTime.Now;

            HttpContext.Session.SetString("name", "gurmeet");
            ViewBag.se = HttpContext.Session.GetString("name");
            return View();
        }
    }
}
