using System;
using System.Collections.Generic;
namespace NextBirthday.Models.Repositories
{
    public interface IRepository
    {
        IEnumerable<Birthday> GetBirthdays();
        void InsertBirthday(Birthday birthday);
        void Save();
    }
}
