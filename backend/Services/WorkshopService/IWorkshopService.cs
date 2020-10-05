using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend.model;

namespace backend.Services.WorkshopService
{
    interface IWorkshopService
    {
        List<Workshop> GetAllWorkshops();
        Workshop GetWorkshopDetails(int id);

    }
}
