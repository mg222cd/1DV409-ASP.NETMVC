using NextBirthday.Models;
using NextBirthday.Models.Repositories;
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

        IRepository _repository;

        public BirthdayController()
            :this(new XmlRepository())
        {

        }

        public BirthdayController(IRepository repository)
        {
            _repository = repository;
        }

        //
        // GET: /Birthday/
        public ActionResult Index()
        {
           
            return View(_repository.GetBirthdays());
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
                _repository.InsertBirthday(birthday);
                _repository.Save();

                return RedirectToAction("Index");
            }

            return View();
        }

    }
}
