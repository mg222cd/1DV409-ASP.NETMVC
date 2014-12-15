using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;

namespace GeekTweet.START.Models
{
    public partial class Tweet
    {
        public Tweet()
        {
            //Empty!
        }

        public Tweet(JToken tweetToken, User user)
        {
            Text = (string)tweetToken["text"];
            CreatedAt = DateTime.ParseExact((string)tweetToken["created_at"],
                "ddd MMM dd HH:mm:ss zz00 yyyy", CultureInfo.InvariantCulture);
            UserId = user.UserId;
            User = user;
        }
    }
}