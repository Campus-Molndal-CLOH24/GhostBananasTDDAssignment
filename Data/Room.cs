using System.Collections.Generic;

public class Room
{
    // Namn på rummet, ex "Tomtens verkstad"
    // Här är alltså bara rumsdata, själva logiken sker på andra ställen.
    public string Name { get; set; }

    // Kort beskrivning av rummet. Försök få in stämning och miljöbeskrivningar.
    public string Description { get; set; }

    // Föremål som finns i rummet. Kan vara allt från leksaker till magiska föremål.
    public List<Item> Items { get; set; }

    // Utgångar till andra rum. Använd "norr", "söder", etc. eller annat som kommandon.
    // Detta gör att spelaren kan navigera runt i världen.
    public Dictionary<string, Room> Exits { get; set; }

    public Room()
    {
        // Initiellt tomt, vi fyller på i våra konkreta rumsklasser.
        Items = new List<Item>();
        Exits = new Dictionary<string, Room>();
    }

    // Metod för att koppla detta rum till ett annat.
    // Skriv t.ex. "norr" för att gå till något annat rum.
    // Tänk på att ni måste lägga till utgångar i båda rummen om vi vill kunna gå fram och tillbaka.
    public void AddExit(string direction, Room room)
    {
        if (!Exits.ContainsKey(direction))
        {
            Exits.Add(direction, room);
        }
    }

    // Denna metod används för att visa info om rummet när spelaren tittar sig omkring.
    // Den skriver ut namnet, beskrivningen, vilka föremål som finns och vilka håll man kan gå.
    public string LookAround()
    {
        string info = $"{Name}\n{Description}\n";

        // Om det finns föremål, lista dem
        if (Items.Count > 0)
        {
            info += "I rummet ser du:\n";
            foreach (var item in Items)
            {
                info += $"- {item.Name}\n";
            }
        }

        // Om det finns utgångar, visa dem
        if (Exits.Count > 0)
        {
            info += "Du kan gå mot: ";
            foreach (var exit in Exits.Keys)
            {
                info += $"{exit} ";
            }
            info += "\n";
        }

        return info;
    }
}

