using GhostBananasTDDAssignment.Logic;

/* public class WorkshopStatus
{
    public void ShowStatus(GameStates state)
    {
        Console.WriteLine("=== 🏠 TOMTEVERKSTADEN ===");
        Console.WriteLine($"Tillverkade presenter: {state.ToysMade} 🎁");
        Console.WriteLine($"Glada tomtenissar: {state.HappyElves} 😊");
        Console.WriteLine($"Dagar till jul: {state.DaysUntilChristmas} 📅");
        DrawProgressBar("Julstämning", state.ChristmasSpirit);
    }

    private void DrawProgressBar(string label, int value)
    {
        Console.Write($"{label}: [");
        int bars = value / 5;  // 20 steg totalt

        for (int i = 0; i < 20; i++)
        {
            if (i < bars)
                Console.Write("🎄");
            else
                Console.Write("-");
        }

        Console.WriteLine($"] {value}%");
    }
} */