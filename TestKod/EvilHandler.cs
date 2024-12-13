public class EvilMagicHandler
{
    public bool TryDetectEvilMagic(Item item)
    {
        // Marcus försöker vara listig!
        if (item.Name.Contains("Evil") ||
            item.Description.Contains("MWAHAHAHA") ||
            item.Weight == 666)
        {
            return true;  // Evil magic detected!
        }

        // Kolla efter dolda förbannelser
        return CheckForHiddenCurses(item);
    }

    private bool CheckForHiddenCurses(Item item)
    {
        // Marcus är smart - vi måste vara smartare!
        var cursedWords = new[] {
            "curse", "hex", "evil", "marcus", "bug"
        };

        return cursedWords.Any(word =>
            item.Name.ToLower().Contains(word) ||
            item.Description.ToLower().Contains(word));
    }
}