public class MainMenu
{
    public void ShowMenu()
    {
        Console.Clear();
        Console.WriteLine("=== 🎄 JULTOMTENS KODÄVENTYR 🎄 ===");
        Console.WriteLine("1. Starta Nytt Spel");
        Console.WriteLine("2. Ladda Spel");
        Console.WriteLine("3. Hjälp");
        Console.WriteLine("4. Avsluta");
        Console.WriteLine("================================");
    }

    public void HandleMainMenu()
    {
        var running = true;
        while (running)
        {
            ShowMenu();
            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    StartNewGame();
                    break;
                case "2":
                    LoadGame();
                    break;
                case "3":
                    ShowHelp();
                    break;
                case "4":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Ogiltigt val!");
                    break;
            }
        }
    }
}