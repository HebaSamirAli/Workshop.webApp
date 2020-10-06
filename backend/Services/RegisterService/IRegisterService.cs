using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend.model;

namespace backend.Services.RegisterService
{
     public interface IRegisterService
    {
        Task<List<Register>> GetUserEnrollments(int id);
        Task<string> AddNewEnroll(Register reg);
        Task<String> DeleteEnrollment(int id);
    }
}
