using GeekTweet.START.Models.Repositories;
using GeekTweet.START.Models.Webservices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GeekTweet.START.Models
{
    public class GeekTweetService : GeekTweetServiceBase
    {
        private IGeekTweetRepository _repository;
        private ITwitterWebservice _webservice;

        public GeekTweetService()
            : this(new GeekTweetRepository(), new TwitterWebservice())
        {
            //Empty
        }

        public GeekTweetService (IGeekTweetRepository repository, ITwitterWebservice webservice)
        {
            _repository = repository;
            _webservice = webservice;
        }

        public override User GetUSer(string screenName)
        {
            var user = _repository.FindUserByScreenName(screenName); // <-- om objektet inte hittas får User värdet NULL

            if (user == null)
            {
                user = _webservice.LookupUser(screenName);

                _repository.AddUser(user);
                _repository.Save();
            }

            return user;
        }

        public override void RefreshTweet(User user)
        {

            //if there are no tweets or if it's time to update the tweets...
            if (user.Tweets == null || user.Tweets.Any() || user.NextUpdate < DateTime.Now)
            {
                //delete the old tweets if there are any...
                if (user.Tweets != null)
                {
                    foreach (var tweet in user.Tweets.ToList())
                    {
                        _repository.DeleteTweet(tweet.TweetId);
                    }
                }

                //get the tweets from the webservice and insert them
                foreach (var tweet in _webservice.GetUserTimeLinde(user))
                {
                    _repository.AddTweet(tweet);
                }

                //set the time for the next update...
                user.NextUpdate = DateTime.Now.AddMinutes(1);

                //Save the changes in the repository to the database
                _repository.Save();
            }
        }

        protected override void Dispose(bool disposing)
        {
            _repository.Dispose();
            //_webservice.Dispose();
            base.Dispose(disposing);
        }
    }
}