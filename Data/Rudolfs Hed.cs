public class RudolfsHed : Room
{
    // Logiken f�r interaktioner (t.ex. kasta v�rmekudden, ge g�tor) hanteras i CommandHandler eller GameEngine
    public RudolfsHed()
    {
        Name = "Rudolfs Hed";
        Description = "Du st�r p� en vidstr�ckt, sn�t�ckt hed d�r Rudolf brukar tr�na. " +
                      "Han syns inte till. Var g�mmer han sig? (sn�n, stallet, bastun)";

        Items = new List<Item>();
    }
}
