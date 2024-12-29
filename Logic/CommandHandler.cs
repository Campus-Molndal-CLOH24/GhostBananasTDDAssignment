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
                return "Du måste skriva in ett kommando!";
            }

            // Dela upp kommandot i delar
            string[] commandParts = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            // För enkelhetens skull: ta första ordet som själva kommandot
            string command = commandParts[0].ToLower();

            // Kolla vilket kommando det är och anropa rätt metod
            switch (command)
            {
                case "gå":
                    return HandleMovement(commandParts);

                case "ta":
                case "plocka":
                    return HandlePickup(commandParts);

                case "hjälp":
                case "?":
                    return ShowHelp();

                default:
                    // Om kommandot inte känns igen
                    return $"Nu kunde jag tyvärr inte tolka kommandot '{command}'.";
            }
        }


        /// Hanterar förflyttning ex gå norr
        private string HandleMovement(string[] parts)
        {
            // parts[0] = "gå", parts[1] = "norr" (om spelaren skrev "gå norr")
            if (parts.Length < 2)
            {
                return "Du måste skriva vilken riktning du vill gå åt exempel gå norr.";
            }

            string direction = parts[1].ToLower();

            // Kallar på GameEngine för att faktiskt röra spelaren
            bool movePlayer = _game.MovePlayer(direction);

            if (movePlayer)
            {
                return $"Du går {direction}.";
            }
            else
            {
                return $"Du kan inte gå {direction} just nu.";
            }
        }

        /// Hanterar att plocka upp ett föremål exempel ta nyckel.
        private string HandlePickup(string[] parts)
        {
            if (parts.Length < 2)
            {
                return "Du måste skriva vad du vill plocka upp (ex: 'ta nyckel').";
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

        /// Visar enkel hjälp om vilka kommandon som finns.
        private string ShowHelp()
        {
            return "Tillgängliga kommandon:\n" +
                   "- gå [riktning] (ex: gå norr)\n" +
                   "- ta/plocka [föremål] (ex: ta svärd)\n" +
                   "- hjälp/? (visar denna hjälp)";
        }
    }
}
