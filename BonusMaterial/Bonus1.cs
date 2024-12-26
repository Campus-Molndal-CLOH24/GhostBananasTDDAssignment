/* public class ChristmasAchievements
{
    private readonly Dictionary<string, bool> _achievements = new()
    {
        { "Första Steget", false },      // Hitta första ledtråden
        { "Presentinslagare", false },   // Slå in 10 presenter
        { "Tomtenissehjälpare", false }, // Hjälp 5 tomtenissar
        { "Renwhisperer", false },       // Ge Rudolf en morot
        { "Marcus Nemesis", false }       // Besegra Super Evil Mage Marcus
    };

    public void UnlockAchievement(string name)
    {
        if (_achievements.ContainsKey(name) && !_achievements[name])
        {
            _achievements[name] = true;
            ShowAchievementAnimation(name);
        }
    }

    private void ShowAchievementAnimation(string name)
    {
        Console.WriteLine();
        Console.WriteLine("🌟 PRESTATION UPPLÅST! 🌟");
        Console.WriteLine($"✨ {name} ✨");
        Console.WriteLine();
    }
} */