using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GeekTweet.START.Models
{
    public abstract class GeekTweetServiceBase :IGeekTweetService
    {
        public abstract User GetUSer(string screenName);
        public abstract void RefreshTweet(User user);

        #region IDisposable Members

        protected virtual void Dispose (bool disposing)
        {
        }

        public void Dispose()
        {
            Dispose(true /* disposing */);
            GC.SuppressFinalize(this);
        }

        #endregion
    }
}