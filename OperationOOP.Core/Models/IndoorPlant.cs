namespace OperationOOP.Core.Models
{
    public class IndoorPlant : Plant
    {
        public bool NeedsArtificialLight { get; set; }

        public IndoorPlant(string name, string species, int ageYears, CareLevel careLevel, bool needsArtificialLight)
            : base(name, species, ageYears, careLevel)
        {
            NeedsArtificialLight = needsArtificialLight;
        }

        public override void WaterPlant()
        {
            LastWatered = DateTime.Now;
        }
    }
}
