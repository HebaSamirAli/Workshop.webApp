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
        public bool AddNewEnroll(Register reg)
        {
            _db.Register.Add(reg);
            _db.SaveChangesAsync();
            return true;
        }

        public bool DeleteEnrollment(int id)
        {
            var bookFromDb = _db.Register.FirstOrDefault(u => u.RegId == id);

            if (bookFromDb == null)
            {
                return false;
            }

            _db.Register.Remove(bookFromDb);
            _db.SaveChangesAsync();
            return true;
        }

        public List<Register> GetUserEnrollments(int id)
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
