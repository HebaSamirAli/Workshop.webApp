using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend.model;

namespace backend.Services.RegisterService
{
    interface IRegisterService
    {
        List<Register> GetUserEnrollments(int id);
        Boolean AddNewEnroll(Register reg);
        Boolean DeleteEnrollment(int id);
    }
}
