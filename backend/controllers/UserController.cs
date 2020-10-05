using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using backend.model;
using Newtonsoft.Json;

namespace backend.controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly ApplicationDbContetxt _db;
        public UserController(ApplicationDbContetxt db){_db = db;}

        // ******************* API FUNCTIONS ********************

        // ADD NEW USER ..................................... (ok)
        [HttpPost]
        [Route("adduser")]
        public async Task<IActionResult> AddUser(User user)
        {
            // check if the user data is inserted befor
            var UserFromDb = _db.User.FirstOrDefault(u => u.UserName == user.UserName);
            if (UserFromDb != null)
            {
                return BadRequest("same user name added");
            }
            _db.User.Add(user);
            await _db.SaveChangesAsync();
            return Ok("Successfully added");
        }

        // UPDATE USER DATA ................................. (ok done call)
        [HttpPut]
        public async Task<IActionResult> UpdateUser(User user)
        {
            // check if the user data is exists
            var UserFromDb = _db.User.FirstOrDefault(u => u.UserName == user.UserName);
            if (UserFromDb == null)
            {
                return BadRequest("user is not exist");
            }
            _db.User.Update(user);
            await _db.SaveChangesAsync();
            return Ok("Successfully updated");
        }

        // GET USER Data ................................. (Ok done call)
        [HttpPost("userdata/{id}")]
        
        public async Task<IActionResult> GetUserData(int id)
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
            if (userFromDb == null)
            {
                return NotFound();
            }
            return Ok(JsonConvert.SerializeObject(userFromDb));
        }

        // check for right password ............................ (ok done call)
        [HttpPost("login")]
        public async Task<IActionResult> CheckForUserVerification(User user)
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
            if (userFromDb == null)
            {
                return NotFound("error login");
            }
            return Ok(userFromDb.UserId);
        }

        /////////////////////////// for check data //////////////////////////

        // GET all USER DETAILS ........................... (ok) >>>>>>>>>>>>>>>>>>>>>>> used to check the data
        /*
        [HttpGet]
        [Route("getall")]
        public async Task<IActionResult> GetAllUsers()
        {
            var UserFromDb = _db.User;
            return Ok(JsonConvert.SerializeObject(UserFromDb));
        }
        */

    }
}
 