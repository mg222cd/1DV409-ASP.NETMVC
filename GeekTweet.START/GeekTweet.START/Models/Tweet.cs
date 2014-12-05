using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;

namespace GeekTweet.START.Models
{
    public class Tweet
    {
        public DateTime CreatedAt { get; set; }
        public string Name { get; set; }
        public string Text { get; set; }

        public Tweet(JToken tweetToken)
        {
            //översätt det som tweetToken innehåller till CreatedAt, Name och Text
            //man kan tänka sig det som en associativ array, där namnet i json är samma som nyckeln. Är nästlat i nivårer.
            CreatedAt = DateTime.ParseExact((tweetToken["created_at"]).ToString(),
                "ddd MMM dd HH:mm:ss zz00 yyyy", CultureInfo.InvariantCulture);
            Name = (tweetToken["user"]["name"]).ToString();
            Text = (tweetToken["text"]).ToString();
        }
    }
}