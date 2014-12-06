using GeekTweet.START.Models.Webservices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GeekTweet.START.Controllers
{
    public class TwitterController : Controller
    {
        //
        // GET: /Twitter/
        public ActionResult Index()
        {
            var webservice = new TwitterWebservice();
            var tweets = webservice.GetUserTimeline("polisen_kalmar");
            
            return View(tweets);
        }
	}
}