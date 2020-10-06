using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using backend.model;
using System.Text.Json;
using Newtonsoft.Json;
using backend.Services.RegisterService;

namespace backend.controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegisterController : ControllerBase
    {
        private readonly IRegisterService _registerService;
        public RegisterController(IRegisterService registerService)
        {
            _registerService = registerService;
        }

        // ******************* API FUNCTIONS ********************

        // GET ALL USER ENROLLMENTS ....................
        [HttpPost("{id}")]
        public async Task<IActionResult> GetUserEnrollments(int id)
        {
            return Ok(JsonConvert.SerializeObject(_registerService.GetUserEnrollments(id)));
        }

        // ADD NEW ENROLL ............................
        [HttpPost]
        public async Task<IActionResult> AddNewEnroll(Register reg)
        {
            return Ok(_registerService.AddNewEnroll(reg));
        }


        // DELETE ENROLLMENT ........................ 
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEnrollment(int id)
        {   
            return Ok(_registerService.DeleteEnrollment(id));
        }
    }
}
