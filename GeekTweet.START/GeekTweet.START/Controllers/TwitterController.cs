using GeekTweet.START.Models.Webservices;
using GeekTweet.START.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GeekTweet.START.Controllers
{
    public class TwitterController : Controller
    {
        // GET: /Twitter/
        public ActionResult Index()
        {
            return View();
        }

        // GET: /Twitter/
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index([Bind(Include="ScreenName")] TwitterIndexViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var webservice = new TwitterWebservice();
                    model.Tweets = webservice.GetUserTimeline(model.ScreenName);   
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(String.Empty, ex.Message);
            }
            
            return View(model);
        }
	}
}