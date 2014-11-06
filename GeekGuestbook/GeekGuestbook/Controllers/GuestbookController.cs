using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GeekGuestbook.Models;

namespace GeekGuestbook.Controllers
{
    public class GuestbookController : Controller
    {
        private GeekGuestbookEntities _enteties = new GeekGuestbookEntities();

        //
        // GET: /Guestbook/
        public ActionResult Index()
        {
            var model = _enteties.Messages.ToList();

            return View(model);
        }

        //
        // GET: /Guestbook/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Guestbook/Create
        [HttpPost]
        public ActionResult Create(Message model)
        {
            //datumet
            model.Created = DateTime.Now;

            //lägger till den lokala samlingen
            _enteties.Messages.Add(model);

            //lägger till databasen
            _enteties.SaveChanges();

            //tillbaka till listan med inlägg
            return RedirectToAction("Index");
        }


	}
}