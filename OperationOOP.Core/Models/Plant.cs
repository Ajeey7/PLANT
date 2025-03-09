public abstract class Plant : IEntity
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public DateTime LastWatered { get; set; }

    public abstract string PlantType { get; }

    public void Water()
    {
        LastWatered = DateTime.Now;
    }
}
