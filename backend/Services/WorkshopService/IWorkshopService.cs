using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend.model;

namespace backend.Services.WorkshopService
{
    public interface IWorkshopService
    {
        Task<List<Workshop>> GetAllWorkshops();
        Task<Workshop> GetWorkshopDetails(int id);

    }
}
