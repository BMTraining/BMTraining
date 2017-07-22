using BMTraining.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BMTraining.Controllers
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

        public ActionResult Services()
        {
            var model = new Services();
            model.Id = 90;
            model.Name = "Grand Vezir";
            model.ServiceNames = new List<string>() { "Balo", "Sünnet", "Düğün" };

            return View(model);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}