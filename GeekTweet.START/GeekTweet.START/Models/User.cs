using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GeekTweet.START.Models
{
    public partial class User
    {
        public User()
        {
            //Empty!
        }

        public User(JToken userToken)
        {
            Id = userToken.Value<string>("id_str");
            Name = userToken.Value<string>("name");
            ScreenName = userToken.Value<string>("screen_name");
        }
    }
}