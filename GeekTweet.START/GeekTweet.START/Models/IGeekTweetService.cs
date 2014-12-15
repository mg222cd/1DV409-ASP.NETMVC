using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeekTweet.START.Models
{
    public interface IGeekTweetService : IDisposable
    {
        User GetUSer(string screenName);
        void RefreshTweet(User user);
    }
}
