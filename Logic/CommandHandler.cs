public class CommandHandler
{
    private readonly GameEngine _game;

    public CommandHandler(GameEngine game)
    {
        _game = game;
    }

    public string HandleCommand(string input)
    {
        // Plocka ut första ordet i kommandot
        var command = input.ToLower().Split(' ');

        switch (command[0])
        {
            case "gå":
                return HandleMovement(command);

            /* fyll på med fler kommandon */

            case "hjälp":
                return ShowHelp();
            default:
                return "Ho ho ho! Jag förstod inte det kommandot!";
        }
    }

    private string HandleMovement(string[] command)
    {
        if (command.Length < 2)
            return "Vart vill du gå?";

        return _game.MovePlayer(command[1]);
    }
}