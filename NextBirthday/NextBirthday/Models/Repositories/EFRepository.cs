using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NextBirthday.Models.Repositories
{
    public class EFRepository : IRepository
    {
        GeekBirthdayEntities _enteties = new GeekBirthdayEntities();

        public IEnumerable<Birthday> GetBirthdays()
        {
            return _enteties.Birthdays.ToList();
        }

        public void InsertBirthday(Birthday birthday)
        {
            _enteties.Birthdays.Add(birthday);
        }

        public void Save()
        {
            _enteties.SaveChanges();
        }
    }
}