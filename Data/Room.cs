using System.Collections.Generic;
using System.Linq;

namespace GhostBananasTDDAssignment.Data
{
    public class Room
    {
        public string Name { get; set; }
        public string Description { get; set; }

        // Ändrat från List<string> till List<Item>
        public List<Item> Items { get; set; } = new List<Item>();

        // Rummen behöver fortfarande kunna länka till varandra
        public Dictionary<string, Room> Exits { get; set; } = new Dictionary<string, Room>();

        // Metod för att titta runt i rummet
        public string LookAround()
        {
            // Bygg ihop en text som beskriver rummet, föremål och utgångar
            string info = $"Du befinner dig i {Name}.\n{Description}\n";

            // Visa vilka Items som ligger i rummet
            if (Items.Count > 0)
            {
                info += "Du ser följande föremål här: ";
                // Vi visar bara itemets Name. Vill du visa mer kan du även ta med itemets Description.
                var itemNames = Items.Select(item => item.Name);
                info += string.Join(", ", itemNames) + "\n";
            }
            else
            {
                info += "Här finns inga föremål.\n";
            }

            // Visa vilka utgångar som finns
            if (Exits.Count > 0)
            {
                info += $"Utgångar: {string.Join(", ", Exits.Keys)}\n";
            }
            else
            {
                info += "Det finns inga tydliga utgångar här.\n";
            }

            return info;
        }
    }
}
