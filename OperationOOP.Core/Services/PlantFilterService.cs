using System;
using System.Collections.Generic;
using System.Linq;
using OperationOOP.Core.Models;

namespace OperationOOP.Core.Services
{
    public class PlantFilterService
    {
        public List<Plant> FilterByCareLevel(List<Plant> plants, string careLevel)
        {
            return plants.Where(p => p.CareLevel.Equals(careLevel, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public List<Plant> FilterByWateringNeed(List<Plant> plants)
        {
            return plants.Where(p => p.NeedsWatering).ToList();
        }
    }
}
