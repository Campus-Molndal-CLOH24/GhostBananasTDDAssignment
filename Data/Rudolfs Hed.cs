public class RudolfsHed : Room
{
    // Logiken för spelvalen (snön, stallet, bastun) hanteras inte här,
    // utan i exempelvis CommandHandler.
    public RudolfsHed()
    {
        Name = "Rudolfs Hed";
        Description = "Du står på en vidsträckt, snötäckt hed där Rudolf brukar träna. " +
                      "Han syns inte till. Var gömmer han sig? (snön, stallet, bastun)";

        Items = new List<Item>();
    }
}
