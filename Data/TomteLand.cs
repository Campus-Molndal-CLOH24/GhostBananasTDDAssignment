public class Tomteland : Room
{
    public Tomteland() // Logiken för interaktioner (t.ex. laga leksaker, slå in paket) hanteras i CommandHandler eller GameEngine
    {
        Name = "Tomteland";
        Description = "Du står mitt i Tomteland, omgiven av snötäckta granar och färgglada paket. " +
                      "Det doftar pepparkakor och glögg, och i bakgrunden hörs jultoner från 'Nu är det jul här i vårt hus'. " +
                      "På ett bord ser du en station för paketinslagning, och på golvet ligger en trasig leksak som någon verkar ha glömt. " +
                      "Ljuset från en julstjärna glimmar varmt i ett fönster. En röst viskar: 'Grattis, du får ett extra liv!'";

        Items = new List<Item>
        {
            new Item("Limtub", "En liten tub med superlim – perfekt för att laga trasiga leksaker."),
            new Item("Inslagningspapper", "Glittrigt papper att slå in julklappar i."),
            new Item("Trasig Leksak", "En sönderfallen liten trädocka som behöver limmas ihop."),
            new Item("Pepparkakshjärta", "Ett stort hjärta av pepparkaka med texten 'God Jul!' ingraverat.")
        };
    }
}
