using System.Collections.Generic;
using System.Linq;

namespace GhostBananasTDDAssignment.Data
{
    public class Room
    {
        public string Name { get; set; }
        public string Description { get; set; }

        // �ndrat fr�n List<string> till List<Item>
        public List<Item> Items { get; set; } = new List<Item>();

        // Rummen beh�ver fortfarande kunna l�nka till varandra
        public Dictionary<string, Room> Exits { get; set; } = new Dictionary<string, Room>();

        // Metod f�r att titta runt i rummet
        public string LookAround()
        {
            // Bygg ihop en text som beskriver rummet, f�rem�l och utg�ngar
            string info = $"Du befinner dig i {Name}.\n{Description}\n";

            // Visa vilka Items som ligger i rummet
            if (Items.Count > 0)
            {
                info += "Du ser f�ljande f�rem�l h�r: ";
                // Vi visar bara itemets Name. Vill du visa mer kan du �ven ta med itemets Description.
                var itemNames = Items.Select(item => item.Name);
                info += string.Join(", ", itemNames) + "\n";
            }
            else
            {
                info += "H�r finns inga f�rem�l.\n";
            }

            // Visa vilka utg�ngar som finns
            if (Exits.Count > 0)
            {
                info += $"Utg�ngar: {string.Join(", ", Exits.Keys)}\n";
            }
            else
            {
                info += "Det finns inga tydliga utg�ngar h�r.\n";
            }

            return info;
        }

        public void AddExit(string direction, Room room)
        {
            throw new NotImplementedException();
        }
    }
}
