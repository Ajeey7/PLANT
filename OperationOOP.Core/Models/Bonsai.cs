namespace OperationOOP.Core.Models
{
    public class Bonsai : Plant
    {
        
        public DateTime LastPruned { get; set; }
        public BonsaiStyle Style { get; set; }

        

        public Bonsai(string name, string species, int ageYears, CareLevel careLevel, BonsaiStyle style)
            : base(name, species, ageYears, careLevel)
        {
            Style = style;
            LastPruned = DateTime.Now;
        }

        public override void WaterPlant()
        {
            LastWatered = DateTime.Now;
        }
        

    }

    public enum BonsaiStyle
    {
        Chokkan,    // Formal Upright
        Moyogi,     // Informal Upright
        Shakan,     // Slanting
        Kengai,     // Cascade
        HanKengai   // Semi-cascade
    }
    
}
