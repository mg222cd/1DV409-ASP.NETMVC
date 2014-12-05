using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
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
            //CreatedAt = (tweetToken[""]).ToString();
            Name = (tweetToken["user"]["name"]).ToString();
            Text = (tweetToken["text"]).ToString();
        }
    }
}