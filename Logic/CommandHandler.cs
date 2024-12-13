public class CommandHandler
{
    private readonly GameEngine _game;

    public CommandHandler(GameEngine game)
    {
        _game = game;
    }

    public string HandleCommand(string input)
    {
        // Plocka ut f�rsta ordet i kommandot
        var command = input.ToLower().Split(' ');

        switch (command[0])
        {
            case "g�":
                return HandleMovement(command);

            /* fyll p� med fler kommandon */

            case "hj�lp":
                return ShowHelp();
            default:
                return "Ho ho ho! Jag f�rstod inte det kommandot!";
        }
    }

    private string HandleMovement(string[] command)
    {
        if (command.Length < 2)
            return "Vart vill du g�?";

        return _game.MovePlayer(command[1]);
    }
}