using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using backend.model;
using System.Text.Json;
using Newtonsoft.Json;

namespace backend.controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegisterController : ControllerBase
    {
        private readonly ApplicationDbContetxt _db;
        public RegisterController(ApplicationDbContetxt db){_db = db;}

        // ******************* API FUNCTIONS ********************

        // GET ALL USER ENROLLMENTS ......................... (ok done call)
        [HttpPost("{id}")]
        public async Task<IActionResult> GetUserEnrollments(int id)
        {
            List<Register> enrollmentsFromDb = new List<Register>();

            foreach (Register reg in _db.Register)
            {
                if (reg.UserId == id)
                {
                    enrollmentsFromDb.Add(reg);
                }
            };
            if (enrollmentsFromDb.Count <= 0)
            {
                return NotFound();
            }

            return Ok(JsonConvert.SerializeObject(enrollmentsFromDb));
        }

        // ADD NEW ENROLL ..................................... (ok done call)
        [HttpPost]
        public async Task<IActionResult> AddNewEnroll(Register reg)
        {
            // check if this user inrolled in the workshop befor

            _db.Register.Add(reg);
            await _db.SaveChangesAsync();
            return Ok("Successfully Added");
        }


        // DELETE ENROLLMENT ........................ (ok done call)
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEnrollment(int id)
        {
            var bookFromDb = _db.Register.FirstOrDefault(u => u.RegId == id);
            
            if (bookFromDb == null)
            {
                return BadRequest("not found data record");
            }
            
            _db.Register.Remove(bookFromDb);
            await _db.SaveChangesAsync();
            
            return Ok("Successfully Deleted");
        }
    }
}
