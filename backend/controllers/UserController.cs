using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using backend.model;
using Newtonsoft.Json;
using backend.Services.UserService;

namespace backend.controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        // ******************* API FUNCTIONS ********************

        // ADD NEW USER ..................................... (ok)
        [HttpPost]
        [Route("adduser")]
        public async Task<IActionResult> AddNewUser(User user)
        {
            return Ok(_userService.AddNewUser(user));
        }

        // UPDATE USER DATA ................................. (ok done call)
        [HttpPut]
        public async Task<IActionResult> UpdateUser(User user)
        {
            return Ok(_userService.UpdateUser(user));
        }

        // GET USER Data ................................. (Ok done call)
        [HttpPost("userdata/{id}")]
        
        public async Task<IActionResult> GetUserData(int id)
        {
            return Ok(JsonConvert.SerializeObject(_userService.GetUserData(id)));
        }

        // check for right password ............................ (ok done call)
        [HttpPost("login")]
        public async Task<IActionResult> CheckForUserVerification(User user)
        {
           return Ok(await _userService.CheckForUserVerification(user));
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
 