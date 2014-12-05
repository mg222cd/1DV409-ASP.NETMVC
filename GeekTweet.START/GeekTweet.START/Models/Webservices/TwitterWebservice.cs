using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace GeekTweet.START.Models.Webservices
{
    public class TwitterWebservice
    {
        public IEnumerable<Tweet> GetUserTimeline(string screenName)
        {
            string rawJson;

            using(StreamReader reader = new StreamReader(HttpContext.Current.Server.MapPath("~/App_Data/scottgu_timeline.json")))
            {
                //Läser in och stoppar in textfilen i en sträng.
                rawJson = reader.ReadToEnd();
            }

            //gör om textfilen från Json till listobjekt med ref till tweet-objekt
            return JArray.Parse(rawJson).Select(t => new Tweet(t)).ToList();
        }
    }
}