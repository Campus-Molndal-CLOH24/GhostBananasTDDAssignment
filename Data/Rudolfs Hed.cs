public class RudolfsHed : Room
{
    // Logiken för interaktioner (t.ex. kasta värmekudden, ge gåtor) hanteras i CommandHandler eller GameEngine
    public RudolfsHed()
    {
        Name = "Rudolfs Hed";
        Description = "Du står på en vidsträckt, snötäckt hed där Rudolf brukar träna. " +
                      "Han syns inte till. Var gömmer han sig? (snön, stallet, bastun)";

        Items = new List<Item>();
    }
}
