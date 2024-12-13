```csharp
[TestClass]
public class SuperEvilTests
{
	[TestMethod]
	public void EvilMagic_CannotInfectChristmasSpirit()
	{
		// Arrange - Skapar en julstämningsmätare och en ond trollformel
		var spirit = new ChristmasSpiritMeter();
		var evilSpell = new Spell { Type = SpellType.Evil };

		// Act - Lägg till lite julstämning och kasta den onda trollformeln
		spirit.AddSpirit(50);  // Lite julstämning
		evilSpell.Cast(spirit);  // Marcus försöker förstöra

		// Assert - Kontrollera att julstämningen fortfarande är över noll
		Assert.IsTrue(spirit.Level > 0,
			"MWAHAHAHA! Jag förstörde julstämningen! 😈");
	}

	[TestMethod]
	public void EvilBugs_CannotCrashGame()
	{
		// Arrange - Skapar ett julspel och en lista med onda kommandon
		var game = new ChristmasGame();
		var evilCommands = new[] {
			"crash", "null", "undefined", "break", "MWAHAHAHA"
		};

		// Act & Assert - Försök att köra varje kommando och kontrollera att spelet inte kraschar
		foreach (var command in evilCommands)
		{
			Assert.DoesNotThrow(() => game.ProcessCommand(command),
				$"BUSTED! Spelet kraschade på kommando: {command}");
		}
	}
}