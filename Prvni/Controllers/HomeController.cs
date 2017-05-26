using Prvni.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Prvni.Controllers
{
    public class HomeController : Controller
    {

        [HttpPost]
        public ActionResult Index(Kalkulacka kalkulacka)
        {
            if (ModelState.IsValid)
            {
                kalkulacka.Vypocitej();
            }

            return View(kalkulacka);
        }
        // GET: Home
        public ActionResult Index()
        {
            //Generator generator = new Generator();
            //ViewBag.Cislo = generator.VratCislo();
            Kalkulacka kalkulacka = new Kalkulacka();
            return View(kalkulacka);
            
        }

     



      
    }
}