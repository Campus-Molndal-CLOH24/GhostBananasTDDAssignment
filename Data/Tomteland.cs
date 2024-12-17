public class Tomteland : Room
{
    public Tomteland()
    {
        Name = "Tomteland";
        Description = "Du st�r mitt i Tomteland, omgiven av sn�t�ckta granar och f�rgglada paket. " +
                      "H�r doftar det av pepparkakor och gl�gg, och i bakgrunden h�rs toner av 'Nu �r det jul h�r i v�rt hus'. " +
                      "Det finns en station f�r paketinslagning och p� golvet ligger en trasig leksak som beh�ver limmas ihop. " +
                      "N�r du f�rnimmer julens magi h�r du en r�st: 'Grattis, du f�r ett extra liv!'";

        Items = new List<Item>
        {
            new Item("Limtub", "En liten tub med superlim � perfekt f�r att laga trasiga leksaker."),
            new Item("Inslagningspapper", "Glittrigt papper att sl� in julklappar i."),
            new Item("Trasig Leksak", "En s�nderfallen liten tr�docka som beh�ver limmas ihop.")
        };
    }
}
