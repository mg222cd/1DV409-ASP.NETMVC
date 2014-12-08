using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeekTweet.START.Models.Repositories
{
    public interface IGeekTweetRepository : IDisposable
    {
        IEnumerable<Tweet> FindAllTweets();
        Tweet FindTweetById(int id);
        void AddTweet(Tweet tweet);
        void UpdateTweet(Tweet tweet);
        void DeleteTweet(int id);

        IEnumerable<User> FindAllUsers();
        User FindUserById(int id);
        User FindUserByScreenName(string screenName);
        void AddUser(User user);
        void UpdateUser(User user);
        void DeleteUser(int id);

        void Save();
    }
}
