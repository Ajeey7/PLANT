using OperationOOP.Core.Interfaces;
using System;

namespace OperationOOP.Core.Models
{
    public abstract class Plant : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Species { get; set; }
        public int WateringIntervalDays { get; set; }
        public DateTime LastWatered { get; set; }

        protected Plant(string name, string species, int wateringIntervalDays)
        {
            Name = name;
            Species = species;
            WateringIntervalDays = wateringIntervalDays;
            LastWatered = DateTime.Now;
        }

        public DateTime GetNextWateringDate()
        {
            return LastWatered.AddDays(WateringIntervalDays);
        }
    }
}
