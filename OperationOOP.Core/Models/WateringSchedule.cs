using System;

namespace OperationOOP.Core.Models
{
    public class WateringSchedule : IEntity
    {
        public int Id { get; set; }
        public int PlantId { get; set; }
        public DateTime NextWateringDate { get; set; }

        public WateringSchedule(int plantId, DateTime nextWateringDate)
        {
            PlantId = plantId;
            NextWateringDate = nextWateringDate;
        }
    }
}
