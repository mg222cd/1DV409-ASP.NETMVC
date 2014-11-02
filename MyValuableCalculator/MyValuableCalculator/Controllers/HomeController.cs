﻿using MyValuableCalculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyValuableCalculator.ViewModels;

namespace MyValuableCalculator.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            var model = new HomeIndexViewModel
            {
                ElementaryMath = new ElementaryMath()
            };
            return View(model);
        }

        //
        // POST: /Home/

        [HttpPost]
        public ActionResult Index(ElementaryMath elementaryMath)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    elementaryMath.Compute();
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError(String.Empty, ex.Message);
                }
            }

            var model = new HomeIndexViewModel
            {
                ElementaryMath = elementaryMath
            };

            return View(model);
        }
    }
}
