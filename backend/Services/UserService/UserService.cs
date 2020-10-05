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
        public bool AddNewUser(User user)
        {
            // check if the user data is inserted befor
            if (CheckIfUserIsExists(user))
            { return false; }
            _db.User.Add(user);
            _db.SaveChangesAsync();
            return true;
        }

        public bool UpdateUser(User user)
        {
            // check if the user data is exists
            if (!CheckIfUserIsExists(user))
            { return false; }
            _db.User.Update(user);
            _db.SaveChangesAsync();
            return true;
        }

        public bool CheckIfUserIsExists(User user)
        {
            var UserFromDb = _db.User.FirstOrDefault(u => u.UserName == user.UserName);
            if (UserFromDb == null) { return false; }
            return true;
        }

        public User GetUserData(int id)
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

        public User CheckForUserVerification(User user)
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
