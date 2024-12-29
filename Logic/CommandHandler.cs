using System;

namespace GhostBananasTDDAssignment
{
    public class CommandHandler
    {
        private GameEngine _game;

        public CommandHandler(GameEngine game)
        {
            _game = game;
        }

        public string HandleCommand(string input)
        {
            // Om inget skrevs in
            if (string.IsNullOrWhiteSpace(input))
            {
                return "Du m�ste skriva in ett kommando!";
            }

            // Dela upp kommandot i delar
            string[] commandParts = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            // F�r enkelhetens skull: ta f�rsta ordet som sj�lva kommandot
            string command = commandParts[0].ToLower();

            // Kolla vilket kommando det �r och anropa r�tt metod
            switch (command)
            {
                case "g�":
                    return HandleMovement(commandParts);

                case "ta":
                case "plocka":
                    return HandlePickup(commandParts);

                case "hj�lp":
                case "?":
                    return ShowHelp();

                default:
                    // Om kommandot inte k�nns igen
                    return $"Nu kunde jag tyv�rr inte tolka kommandot '{command}'.";
            }
        }


        /// Hanterar f�rflyttning ex g� norr
        private string HandleMovement(string[] parts)
        {
            // parts[0] = "g�", parts[1] = "norr" (om spelaren skrev "g� norr")
            if (parts.Length < 2)
            {
                return "Du m�ste skriva vilken riktning du vill g� �t exempel g� norr.";
            }

            string direction = parts[1].ToLower();

            // Kallar p� GameEngine f�r att faktiskt r�ra spelaren
            bool kundeGa = _game.MovePlayer(direction);

            if (kundeGa)
            {
                return $"Du g�r {direction}.";
            }
            else
            {
                return $"Du kan inte g� {direction} just nu.";
            }
        }

        /// Hanterar att plocka upp ett f�rem�l exempel ta nyckel.
        private string HandlePickup(string[] parts)
        {
            if (parts.Length < 2)
            {
                return "Du m�ste skriva vad du vill plocka upp (ex: 'ta nyckel').";
            }

            string itemName = parts[1].ToLower();

            bool pickedUp = _game.PickupItem(itemName);

            if (pickedUp)
            {
                return $"Du plockade upp {itemName}.";
            }
            else
            {
                return $"Du kan inte plocka upp '{itemName}' just nu.";
            }
        }

        /// Visar enkel hj�lp om vilka kommandon som finns.
        private string ShowHelp()
        {
            return "Tillg�ngliga kommandon:\n" +
                   "- g� [riktning] (ex: g� norr)\n" +
                   "- ta/plocka [f�rem�l] (ex: ta sv�rd)\n" +
                   "- hj�lp/? (visar denna hj�lp)";
        }
    }
}
