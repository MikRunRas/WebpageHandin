using System.Collections.Generic;
using AdultWebpageHandin.Pages;
using Models;

namespace LoginExample.Data.Impl
{
    public interface IUserData
    {
        IList<User> GetUsers();
            void AddUser(User user);
            void RemoveUser(int Id);
            void Update(User user);
            User Get(int id);
    }
}