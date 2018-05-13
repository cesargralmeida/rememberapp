using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ToyApp.Models;

namespace ToyApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View(new IndexModel());
        }
        [HttpPost]
        public ActionResult Index(IndexModel model)
        {
            ViewBag.message = model.Quotes[model.Category][new Random().Next(0, 3)];
            return View(new IndexModel());
        }
    }
}