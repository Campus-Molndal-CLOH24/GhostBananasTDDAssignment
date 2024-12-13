/// <summary>
/// Represents the main menu of the game "JULTOMTENS KODÄVENTYR".
/// </summary>
public class MainMenu
{
    /// <summary>
    /// Displays the main menu options to the console.
    /// </summary>
    public void ShowMenu()
    {
        // Clears the console screen.
        Console.Clear();
        // Displays the title and menu options.
        Console.WriteLine("=== 🎄 JULTOMTENS KODÄVENTYR 🎄 ===");
        Console.WriteLine("1. Starta Nytt Spel");
        Console.WriteLine("2. Ladda Spel");
        Console.WriteLine("3. Hjälp");
        Console.WriteLine("4. Avsluta");
        Console.WriteLine("================================");
    }

    /// <summary>
    /// Handles the user's input for the main menu and performs the corresponding actions.
    /// </summary>
    public void HandleMainMenu()
    {
        // Variable to keep the menu running.
        var running = true;
        while (running)
        {
            // Displays the menu.
            ShowMenu();
            // Reads the user's choice.
            var choice = Console.ReadLine();

            // Executes the corresponding action based on the user's choice.
            switch (choice)
            {
                case "1":
                    // Starts a new game.
                    StartNewGame();
                    break;
                case "2":
                    // Loads an existing game.
                    LoadGame();
                    break;
                case "3":
                    // Shows help information.
                    ShowHelp();
                    break;
                case "4":
                    // Exits the menu.
                    running = false;
                    break;
                case "1337":
                    // Easter egg for fun.
                    Console.WriteLine("🎅 Ho ho ho! 🎅");
                    break;
                case "666":
                    // Easter egg for fun.
                    Console.WriteLine("👹 The number of the beast! 👹");
                    break;
                case "20041225":
                    // Godmode cheat code.
                    player.Godmode = true;
                    player.MaxHealth = 999;
                    player.Health = 999;
                    player.Damage = 999;
                    player.Defense = 999;
                    player.MaxInventory = 999;
                    player.Inventory.Add(new Item("🔥 God Sword", "A legendary sword that can slay anything!"));
                    Console.WriteLine("💪 God mode activated! 💪");
                    break;
                default:
                    // Informs the user of an invalid choice.
                    Console.WriteLine("Ogiltigt val!");
                    break;
            }
        }
    }
}

/// <summary>
/// Command to move the player in the game.
/// </summary>
public class MoveCommand : ICommandHandler
{
    // The current state of the game.
    // This is where the player's position and the game world are stored.
    private readonly GameState _gameState;

    /// <summary>
    /// Initializes a new instance of the <see cref="MoveCommand"/> class.
    /// </summary>
    /// <param name="gameState">The current state of the game.</param>
    public MoveCommand(GameState gameState)
    {
        _gameState = gameState;
    }

    /// <summary>
    /// Executes the move command with the given arguments.
    /// </summary>
    /// <param name="args">The arguments for the move command.</param>
    /// <returns>A string result of the move command execution.</returns>
    public string Execute(string[] args)
    {
        if (args.Length < 2)
            return "Vart vill du gå?"; // "Where do you want to go?" in Swedish

        var direction = args[1].ToLower();
        return _gameState.MovePlayer(direction);
    }
}