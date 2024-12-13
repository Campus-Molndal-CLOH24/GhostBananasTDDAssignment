public class SnowAnimation
{
    private const int WIDTH = 60;
    private const int HEIGHT = 20;
    private readonly Random _random = new();
    private readonly char[] _snowflakes = new[] { '*', '❄', '❅', '❆' };

    public void ShowSnow()
    {
        Console.Clear();
        var snow = new char[HEIGHT, WIDTH];

        // Initiera snöflingor
        for (int i = 0; i < HEIGHT; i++)
            for (int j = 0; j < WIDTH; j++)
            {
                snow[i, j] = _random.Next(10) == 0
                    ? _snowflakes[_random.Next(_snowflakes.Length)]
                    : ' ';
            }

        // Rita snön
        for (int i = 0; i < HEIGHT; i++)
        {
            for (int j = 0; j < WIDTH; j++)
            {
                Console.Write(snow[i, j]);
            }
            Console.WriteLine();
        }
    }
}