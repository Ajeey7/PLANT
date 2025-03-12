using System;
using System.Collections.Generic;
using System.Linq;


namespace OperationOOP.Core.Models
{
    public class PlantFilterService
    {
        // Filtrerar växter baserat på vårdnivå
        public List<Plant> FilterByCareLevel(List<Plant> plants, string careLevel)
        {
            if (Enum.TryParse<CareLevel>(careLevel, true, out CareLevel parsedLevel))
            {
                return plants.Where(p => p.CareLevel == parsedLevel).ToList();
            }
            return new List<Plant>(); // Returnera tom lista om vårdnivån inte matchar
        }

        // Filtrerar växter som behöver vattnas
        public List<Plant> FilterByWateringNeed(List<Plant> plants)
        {
            return plants.Where(p => (DateTime.Now - p.LastWatered).TotalDays >= 3).ToList(); 
        }
    }
}
