using System.Collections.Generic;

public class Room
{
    // Namn p� rummet, ex "Tomtens verkstad"
    // H�r �r allts� bara rumsdata, sj�lva logiken sker p� andra st�llen.
    public string Name { get; set; }

    // Kort beskrivning av rummet. F�rs�k f� in st�mning och milj�beskrivningar.
    public string Description { get; set; }

    // F�rem�l som finns i rummet. Kan vara allt fr�n leksaker till magiska f�rem�l.
    public List<Item> Items { get; set; }

    // Utg�ngar till andra rum. Anv�nd "norr", "s�der", etc. eller annat som kommandon.
    // Detta g�r att spelaren kan navigera runt i v�rlden.
    public Dictionary<string, Room> Exits { get; set; }

    public Room()
    {
        // Initiellt tomt, vi fyller p� i v�ra konkreta rumsklasser.
        Items = new List<Item>();
        Exits = new Dictionary<string, Room>();
    }

    // Metod f�r att koppla detta rum till ett annat.
    // Skriv t.ex. "norr" f�r att g� till n�got annat rum.
    // T�nk p� att ni m�ste l�gga till utg�ngar i b�da rummen om vi vill kunna g� fram och tillbaka.
    public void AddExit(string direction, Room room)
    {
        if (!Exits.ContainsKey(direction))
        {
            Exits.Add(direction, room);
        }
    }

    // Denna metod anv�nds f�r att visa info om rummet n�r spelaren tittar sig omkring.
    // Den skriver ut namnet, beskrivningen, vilka f�rem�l som finns och vilka h�ll man kan g�.
    public string LookAround()
    {
        string info = $"{Name}\n{Description}\n";

        // Om det finns f�rem�l, lista dem
        if (Items.Count > 0)
        {
            info += "I rummet ser du:\n";
            foreach (var item in Items)
            {
                info += $"- {item.Name}\n";
            }
        }

        // Om det finns utg�ngar, visa dem
        if (Exits.Count > 0)
        {
            info += "Du kan g� mot: ";
            foreach (var exit in Exits.Keys)
            {
                info += $"{exit} ";
            }
            info += "\n";
        }

        return info;
    }
}

