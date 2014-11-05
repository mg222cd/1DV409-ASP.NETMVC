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
        // POST: /Guestbook/Create
        [HttpPost]
        public ActionResult Create(Message model)
        {
            return View();
        }


	}
}