using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend.model;
using Microsoft.EntityFrameworkCore.Update.Internal;

namespace backend.Services.UserService
{
    interface IUserService
    {
        Boolean CheckIfUserIsExists(User user);
        User GetUserData(int id);
        User CheckForUserVerification(User user);
        Boolean AddNewUser(User user);
        Boolean UpdateUser(User user);
    }
}
