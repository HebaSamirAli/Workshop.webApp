using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend.model;

namespace backend.Services.RegisterService
{
    public class RegisterService : IRegisterService
    {
        private readonly ApplicationDbContetxt _db;
        public RegisterService(ApplicationDbContetxt db)
        {
            _db = db;
        }
        public async Task<string> AddNewEnroll(Register reg)
        {
            //checked if the user enrolled before with the workshop
            var registerFromDb = _db.Register.FirstOrDefault(u => (u.RegId == reg.RegId) && (u.WorkshopId == reg.WorkshopId));
            if (registerFromDb != null)
            {
                return "You have enrolled in this workshop befor";
            }
            _db.Register.Add(reg);
            await _db.SaveChangesAsync();
            return "Successfully Added";
        }

        public async Task<string> DeleteEnrollment(int id)
        {
            // check if enrollment is in db
            var registerFromDb = _db.Register.FirstOrDefault(u => u.RegId == id);
            if (registerFromDb == null)
            {
                return "Error deleting or you don't enrolled for this workshop before";
            }
            _db.Register.Remove(registerFromDb);
            await _db.SaveChangesAsync();
            return "Successfully Deleted";
        }

        public async Task<List<Register>> GetUserEnrollments(int id)
        {
            List<Register> enrollmentsFromDb = new List<Register>();
            foreach (Register reg in _db.Register)
            {
                if (reg.UserId == id)
                {
                    enrollmentsFromDb.Add(reg);
                }
            };
            return enrollmentsFromDb;
        }

      
    }
}
