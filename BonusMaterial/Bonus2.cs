/* public class ChristmasMusicPlayer
{
	private readonly string[] _musicNotes = new[] { "🎵", "🎶" };
	private int _noteIndex = 0;

	public void PlayJingleBells()
	{
		Console.WriteLine(@"
            🎄 Jingle Bells Spelas 🎄
        ");

		for (int i = 0; i < 10; i++)
		{
			Console.Write($"\r{_musicNotes[_noteIndex]} ");
			_noteIndex = (_noteIndex + 1) % _musicNotes.Length;
			Thread.Sleep(500);
		}
		Console.WriteLine("\nHo ho ho!");
	}
} */