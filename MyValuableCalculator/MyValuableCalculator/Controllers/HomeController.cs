using MyValuableCalculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyValuableCalculator.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            var model = new ElementaryMath();
            return View(model);
        }

        //
        // POST: /Home/

        [HttpPost]
        public ActionResult Index(ElementaryMath elementaryMath)
        {
            if (ModelState.IsValid)
            {
                elementaryMath.Compute();
            }
            return View(elementaryMath);
        }
    }
}
