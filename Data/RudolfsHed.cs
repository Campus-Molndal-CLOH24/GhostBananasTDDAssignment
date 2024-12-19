public class RudolfsHed : Room
{
    // Logiken för interaktioner (t.ex. lokalisera Rudolf, använda värmekudden) hanteras i CommandHandler eller GameEngine
    public RudolfsHed()
    {
        Name = "Rudolfs Hed";
        Description = "Du står på en vidsträckt, snötäckt hed där Rudolf brukar träna sina flygningar. " +
                      "Den kalla vinden biter i kinderna och du kan se spår i snön som leder åt olika håll. " +
                      "Rudolf syns inte till. Var gömmer han sig? (snön, stallet, bastun)\n\n" +
                      "På avstånd hörs dova bjällror från andra renar, och luften doftar svagt av gran. " +
                      "Det är stilla, men du anar att något eller någon gömmer sig i det vita landskapet.";

        Items = new List<Item>
        {
            new Item("Höbunt", "En liten bunt torrt hö, perfekt för att locka fram en hungrig ren."),
            new Item("Renbjällra", "En bjällra som renarna brukar bära. Den klirrar fint och kan användas för att få uppmärksamhet."),
            new Item("Värmeschal", "En lång, stickad schal som värmer i den isiga vinden."),
            new Item("Snöskyffel", "En liten skyffel som kan användas för att gräva i snön, kanske för att leta efter något gömt.")
        };
    }
}
