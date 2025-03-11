using System;
using System.Collections.Generic;
using System.Linq;

namespace OperationOOP.Core.Models
{
    public class WateringSchedule
    {
        private readonly List<Plant> _plants;

        public WateringSchedule(List<Plant> plants)
        {
            _plants = plants;
        }

        public List<Plant> GetPlantsNeedingWatering()
        {
            DateTime today = DateTime.Today;
            return _plants.Where(p => p.GetNextWateringDate() <= today).ToList();
        }
    }
}
