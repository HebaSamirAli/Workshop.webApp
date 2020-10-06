using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using backend.model;
using backend.Services;
using Newtonsoft.Json;
using backend.Services.WorkshopService;

namespace backend.controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkshopsListController : ControllerBase
    {
        private readonly IWorkshopService _workshopService;
        public WorkshopsListController(IWorkshopService workshopService)
        {
            _workshopService = workshopService;
        }

        // ******************* API FUNCTIONS ********************

        // GET ALL WORKSHOPS .......................... (ok done call)
        [HttpGet]
        [Route("GetAll")]
        public async Task<IActionResult> GetAllWorkshops()
        {
            return Ok(JsonConvert.SerializeObject(_workshopService.GetAllWorkshops()));
        }


        // GET WORKSHOP DETAIL DATA .................... (ok done call)
        [HttpGet("{id}")]
        public async Task<IActionResult> GetWorkshopDetails(int id)
        {
            return Ok(JsonConvert.SerializeObject(_workshopService.GetWorkshopDetails(id)));
        }
    }
}
