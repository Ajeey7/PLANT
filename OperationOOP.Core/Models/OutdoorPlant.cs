namespace OperationOOP.Core.Models
{
    public class OutdoorPlant : Plant
    {
        public bool WinterHardy { get; set; }

        public OutdoorPlant(string name, string species, int wateringIntervalDays, bool winterHardy)
            : base(name, species, wateringIntervalDays)
        {
            WinterHardy = winterHardy;
        }
    }
}

