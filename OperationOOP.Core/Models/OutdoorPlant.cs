namespace OperationOOP.Core.Models
{
    public class OutdoorPlant : Plant
    {
        public bool WinterHardy { get; set; }

        public OutdoorPlant(string name, string species, int ageYears, CareLevel careLevel, bool winterHardy)
            : base(name, species, ageYears, careLevel)
        {
            WinterHardy = winterHardy;
        }

        public override void WaterPlant()
        {
            LastWatered = DateTime.Now;
        }
    }
}
