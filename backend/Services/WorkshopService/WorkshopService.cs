using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend.model;

namespace backend.Services.WorkshopService
{
    public class WorkshopService : IWorkshopService
    {
        private readonly ApplicationDbContetxt _db;
        public WorkshopService(ApplicationDbContetxt db)
        {
            _db = db;
        }
        
        public List<Workshop> GetAllWorkshops()
        {
            List<Workshop> workshopsFromDb = new List<Workshop>();
            foreach (Workshop workshop in _db.Workshop) { workshopsFromDb.Add(workshop); };
            return workshopsFromDb;
        }

        public Workshop GetWorkshopDetails(int id)
        {
            Workshop workshopsFromDb = new Workshop();
            foreach (Workshop workshop in _db.Workshop)
            {
                if (workshop.WorkshopId == id) { workshopsFromDb = workshop; }
            };
            return workshopsFromDb;
        }
    }
}
