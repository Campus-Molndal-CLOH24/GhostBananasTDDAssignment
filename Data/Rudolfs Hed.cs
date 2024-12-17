public class RudolfsHed : Room
{
    // Logiken f�r spelvalen (sn�n, stallet, bastun) hanteras inte h�r,
    // utan i exempelvis CommandHandler.
    public RudolfsHed()
    {
        Name = "Rudolfs Hed";
        Description = "Du st�r p� en vidstr�ckt, sn�t�ckt hed d�r Rudolf brukar tr�na. " +
                      "Han syns inte till. Var g�mmer han sig? (sn�n, stallet, bastun)";

        Items = new List<Item>();
    }
}
