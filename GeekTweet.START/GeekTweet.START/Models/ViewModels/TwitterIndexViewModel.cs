using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GeekTweet.START.Models.ViewModels
{
    public class TwitterIndexViewModel
    {
        public string ScreenName { get; set; }

        public bool HasTweets
        {
            get { return Tweets != null && Tweets.Any(); }
        }

        public string Name
        {
            get
            {
                return HasTweets ? Tweets.First().Name : "[Unknown]";
            }
        }

        //referens till samlingen med tweets
        public IEnumerable<Tweet> Tweets { get; set; }
    }
}