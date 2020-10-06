using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend.model;

namespace backend.Services.UserService
{
    public class UserService : IUserService
    {
        private readonly ApplicationDbContetxt _db;

        public UserService(ApplicationDbContetxt db)
        {
            _db = db;
        }
        public async Task<string> AddNewUser(User user)
        {
            // check if the user data is exists
            var check = await CheckIfUserIsExists(user);
            if (check)
            { return "Error this user name is added before"; }
            _db.User.Add(user);
            await _db.SaveChangesAsync();
            return "Successfully added";
        }

        public async Task<string> UpdateUser(User user)
        {
            // check if the user data is exists
            var check = await CheckIfUserIsExists(user);
            if (!check)
            { return "Error there is no user with this name"; }
            _db.User.Update(user);
            await _db.SaveChangesAsync();
            return "successfully updated";
        }

        public async Task<Boolean> CheckIfUserIsExists(User user)
        {
            var UserFromDb = _db.User.FirstOrDefault(u => u.UserName == user.UserName);
            if (UserFromDb == null) { return false; }
            return true;
        }

        public async Task<User> GetUserData(int id)
        {
            User userFromDb = new User();
            foreach (User user in _db.User)
            {
                if (user.UserId == id)
                {
                    userFromDb.UserId = user.UserId;
                    userFromDb.UserName = user.UserName;
                }
            };
            return userFromDb;
        }

        public async Task<User> CheckForUserVerification(User user)
        {
            User userFromDb = new User();
            foreach (User _user in _db.User)
            {
                //HashCode password.........

                if (_user.UserName == user.UserName && _user.UserEmail == user.UserEmail && _user.Password == user.Password)
                {
                    userFromDb = _user;
                }
            };
            return userFromDb;
        }
    }
}
