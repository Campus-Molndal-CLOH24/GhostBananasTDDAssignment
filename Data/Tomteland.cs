public class Tomteland : Room
{
    public Tomteland()
    {
        Name = "Tomteland";
        Description = "Du står mitt i Tomteland, omgiven av snötäckta granar och färgglada paket. " +
                      "Här doftar det av pepparkakor och glögg, och i bakgrunden hörs toner av 'Nu är det jul här i vårt hus'. " +
                      "Det finns en station för paketinslagning och på golvet ligger en trasig leksak som behöver limmas ihop. " +
                      "När du förnimmer julens magi hör du en röst: 'Grattis, du får ett extra liv!'";

        Items = new List<Item>
        {
            new Item("Limtub", "En liten tub med superlim – perfekt för att laga trasiga leksaker."),
            new Item("Inslagningspapper", "Glittrigt papper att slå in julklappar i."),
            new Item("Trasig Leksak", "En sönderfallen liten trädocka som behöver limmas ihop.")
        };
    }
}
