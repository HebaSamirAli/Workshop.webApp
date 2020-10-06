using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend.model;
using Microsoft.EntityFrameworkCore.Update.Internal;

namespace backend.Services.UserService
{
    public interface IUserService
    {
        Task<Boolean> CheckIfUserIsExists(User user);
        Task<User> GetUserData(int id);
        Task<User> CheckForUserVerification(User user);
        Task<string> AddNewUser(User user);
        Task<string> UpdateUser(User user);
    }
}
