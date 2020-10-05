using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using backend.model;
using Newtonsoft.Json;

namespace backend.controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkshopsListController : ControllerBase
    {
        private readonly ApplicationDbContetxt _db;
        public WorkshopsListController(ApplicationDbContetxt db){_db = db;}

        // ******************* API FUNCTIONS ********************

        // GET ALL WORKSHOPS .......................... (ok done call)
        [HttpGet]
        [Route("GetAll")]
        public async Task<IActionResult> GetAllWorkshops()
        {
            List<Workshop> workshopsFromDb = new List<Workshop>();
            foreach (Workshop workshop in _db.Workshop) {workshopsFromDb.Add(workshop);};
            if (workshopsFromDb.Count <= 0) {return NotFound();}
            return Ok(JsonConvert.SerializeObject(workshopsFromDb));
        }


        // GET WORKSHOP DETAIL DATA .................... (ok done call)
        [HttpGet("{id}")]
        public async Task<IActionResult> GetWorkshopDetails(int id)
        {
            Workshop workshopsFromDb = new Workshop();
            foreach (Workshop workshop in _db.Workshop)
            {
                if (workshop.WorkshopId == id) { workshopsFromDb = workshop; }
            };
            if (workshopsFromDb == null) { return NotFound(); }
            return Ok(JsonConvert.SerializeObject(workshopsFromDb));
        }
    }
}
