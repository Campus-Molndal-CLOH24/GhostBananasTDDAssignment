using GhostBananasTDDAssignment.Data;

public class Item
{
    public string Name { get; set; }
    public string Description { get; set; }
    public bool IsMagical { get; set; }
    public int Weight { get; set; }

    public Item(string name, string description)
    {
        Name = name;
        Description = description;
        IsMagical = false;
    }
}