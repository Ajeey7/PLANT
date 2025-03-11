using Microsoft.AspNetCore.Mvc;
using OperationOOP.Core.Models;
using OperationOOP.Core.Services;
using System.Collections.Generic;

namespace OperationOOP.Api.Controllers
{
    [Route("api/plants")]
    [ApiController]
    public class PlantsController : ControllerBase
    {
        private readonly PlantService _plantService;

        public PlantsController()
        {
            _plantService = new PlantService();
        }

        // Endpoint för att hämta alla växter
        [HttpGet]
        public ActionResult<List<Plant>> GetAll()
        {
            return Ok(_plantService.GetAllPlants());
        }

        // Endpoint för att filtrera växter efter vårdnivå
        [HttpGet("care-level/{level}")]
        public ActionResult<List<Plant>> GetByCareLevel(int level)
        {
            return Ok(_plantService.GetPlantsByCareLevel(level));
        }

        // Endpoint för att lägga till en ny växt
        [HttpPost]
        public ActionResult AddPlant([FromBody] Plant plant)
        {
            _plantService.AddPlant(plant);
            return CreatedAtAction(nameof(GetAll), new { id = plant.Id }, plant);
        }
    }
}
