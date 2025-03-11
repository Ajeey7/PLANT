namespace OperationOOP.Core.Models
{
    public class IndoorPlant : Plant
    {
        public bool NeedsArtificialLight { get; set; }

        public IndoorPlant(string name, string species, int wateringIntervalDays, bool needsArtificialLight)
            : base(name, species, wateringIntervalDays)
        {
            NeedsArtificialLight = needsArtificialLight;
        }
    }
}
