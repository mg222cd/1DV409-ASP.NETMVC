using NextBirthday.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml.Linq;

namespace NextBirthday.Controllers
{
    public class BirthdayController : Controller
    {
        //
        // GET: /Birthday/
        public ActionResult Index()
        {
            var path = Server.MapPath("~/App_Data/birthdates.xml");
            var doc = XDocument.Load(path);
            var model = (from birthdate in doc.Descendants("birthdate")
                         select new Birthday 
                         {
                             Name = birthdate.Element("name").Value,
                             Birthdate = DateTime.Parse(birthdate.Element("date").Value),
                         }).OrderBy(b => b.DaysUntilNextBirthday).ToList();

            return View(model);
        }

        //
        // GET: /Birthday/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Birthday/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Birthday birthday)
        {
            if (ModelState.IsValid)
            {
                var path = Server.MapPath("~/App_Data/birthdates.xml");
                var doc = XDocument.Load(path);

                var element = new XElement("birthdate",
                    new XElement("name", birthday.Name),
                    new XElement("date", birthday.Birthdate));

                doc.Root.Add(element);
                doc.Save(path);

                return RedirectToAction("Index");
            }

            return View();
        }

    }
}
