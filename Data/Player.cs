using System.Collections.Generic;
using GhostBananasTDDAssignment.Data; 

namespace GhostBananasTDDAssignment.Data
{
    public class Player
    {
        // T.ex. en enkel inventory listan av "Item" eller "string"
        public List<Item> Inventory { get; set; } = new List<Item>();

        // Referens till rummets klass
        public Room CurrentRoom { get; set; }

        public string Name { get; set; }

        public Player(string name)
        {
            Name = name;
        }
    }
}
