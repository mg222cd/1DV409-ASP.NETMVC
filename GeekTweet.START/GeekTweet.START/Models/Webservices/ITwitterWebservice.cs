using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GeekTweet.START.Models.Webservices
{
    public interface ITwitterWebservice
    {
        IEnumerable<Tweet> GetUserTimeLinde(User user);
        User LookupUser(string screenName);
    }
}