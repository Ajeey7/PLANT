using System;

namespace OperationOOP.Core.Models
{
    public class WateringSchedule
    {
        public int Id { get; set; }
        public int PlantId { get; set; }
        public DateTime NextWateringDate { get; set; }

        public WateringSchedule(int plantId, DateTime lastWatered, int wateringIntervalDays)
        {
            PlantId = plantId;
            NextWateringDate = lastWatered.AddDays(wateringIntervalDays);
        }

        // Beräknar antal dagar kvar till nästa vattning
        public int DaysUntilNextWatering()
        {
            return (NextWateringDate - DateTime.Now).Days;
        }

        // Hämtar nästa vattningsdatum
        public DateTime GetNextWateringDate()
        {
            return NextWateringDate;
        }
    }
}
