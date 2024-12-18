public class IsgrottansHjarta : Room
{
    // Logiken för interaktioner (t.ex. kasta värmekudden, ge gåtor) hanteras i CommandHandler eller GameEngine
    public IsgrottansHjarta()
    {
        Name = "Isgrottans Hjärta";
        Description = "Du befinner dig i Isgrottans allra innersta rum. Väggarna av tjock is glimmar i skenet " +
                      "från en ensam islykta, och golvet är täckt av frostblommor. " +
                      "Mitt i rummet står den fruktade Marcus, iklädd en luva, med ett isklot i händerna. " +
                      "Din värmekudde kan kanske smälta isklotet och befria presenterna. " +
                      "När isklotet smälter dyker pepparkakshjälten fram och snor åt sig säcken. " +
                      "Men Marcus vakter formar en ogenomtränglig mur framför utgången. " +
                      "Du erbjuder Marcus en gåta:\n" +
                      "\"Du kommer till ett vägskäl där en väg leder till en skatt och den andra leder till säker död.\"\n" +
                      "Ska Marcus svara rätt eller fel? Fel = du går fri, rätt = du delar dina julklappar.\n\n" +
                      "Rummet doftar svagt av isblommor och du hör ett svagt droppande ljud när iskristaller smälter " +
                      "långsamt under din andedräkt.";

        Items = new List<Item>
        {
            new Item("Islyktan", "En vackert uthuggen lykta av is, den enda ljuskällan i rummet."),
            new Item("Frostblommor", "Ömtåliga, glittrande isblommor som växer ur golvets sprickor."),
            new Item("Glasbit", "En skärva av iskristall från väggen, kall och hal i handen."),
            new Item("Isnyckel", "En nyckel formad av is. Kanske kan den öppna något längre fram."),
        };
    }
}
