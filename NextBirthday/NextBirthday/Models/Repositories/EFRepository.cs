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
            throw new NotImplementedException();
        }

        public void Sace()
        {
            throw new NotImplementedException();
        }
    }
}