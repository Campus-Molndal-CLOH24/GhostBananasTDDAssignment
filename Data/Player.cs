public class Player
{
    public string Name { get; set; }
    public List<Item> Inventory { get; private set; }
    public Room CurrentRoom { get; set; }

    public Player(string name)
    {
        Name = name;
        Inventory = new List<Item>();
    }

    public bool AddItem(Item item)
    {
        if (Inventory.Count >= 5) // Du bestämmer själv maxgränsen
        {
            return false; // Inventory fullt!
        }
        Inventory.Add(item);
        return true;
    }
}