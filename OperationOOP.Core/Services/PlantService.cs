using OperationOOP.Core.Models;
using System.Collections.Generic;
using System.Linq;

namespace OperationOOP.Core.Services
{
    public class PlantService
    {
        private readonly List<Plant> _plants = new();

        public List<Plant> GetAllPlants() => _plants;

        public List<Plant> GetPlantsByCareLevel(int level)
        {
            return _plants.Where(p => p.WateringIntervalDays <= level).ToList();
        }

        public void AddPlant(Plant plant)
        {
            _plants.Add(plant);
        }
    }
}
