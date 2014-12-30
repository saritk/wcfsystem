using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Contracts;
using PersistenceLayer.Entities;

namespace PersistenceLayer
{
    public interface IUserRepository
    {
        UserDo GetUser(int id);
        IEnumerable<UserDo> GetUsers();
        void DeleteUser(User user);
        void UpdateUser(User user);
        UserDo CreateUser(User user);
    }
}
