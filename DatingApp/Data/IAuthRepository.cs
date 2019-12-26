using DatingApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatingApp.Data
{
    public interface IAuthRepository
    {
        Task<User> Register(User user, string password);  //returning a task of user
        Task<User> Login(string username, string password);

        Task<bool> UserExists(string username);
    }
}
