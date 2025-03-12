using System;

namespace OperationOOP.Core.Models
{
    public enum CareLevel
    {
        Hard,
        Easy
    }

    public abstract class Plant
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Species { get; set; }
        public int AgeYears { get; set; }
        public DateTime LastWatered { get; set; }
        public CareLevel CareLevel { get; set; }

        // Abstrakt metod som subklasser måste implementera
        public abstract void WaterPlant();
        
        // Konstruktor
        protected Plant(string name, string species, int ageYears, CareLevel careLevel)
        {
            Name = name;
            Species = species;
            AgeYears = ageYears;
            CareLevel = careLevel;
            LastWatered = DateTime.Now; // Standardvärde
        }
    }
}
