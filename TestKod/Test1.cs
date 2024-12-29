/*[TestClass]
public class PlayerTests
{
    private Player _player;
    private Item _magicItem;

    [TestInitialize]
    public void Setup()
    {
        // Skapar en ny spelare och en magisk klocka innan varje test
        _player = new Player("TestTomte");
        _magicItem = new Item("Magisk Klocka", "Ringer sj�lv vid midnatt")
        {
            IsMagical = true,
            Weight = 5
        };
    }

    [TestMethod]
    public void AddItem_WhenInventoryNotFull_ReturnsTrue()
    {
        // Arrange �r redan fixat i Setup

        // Act - F�rs�ker l�gga till en magisk klocka i spelarens inventarie
        var result = _player.AddItem(_magicItem);

        // Assert - Kontrollera att resultatet �r sant och att klockan finns i inventariet
        Assert.IsTrue(result, "Tomten m�ste kunna b�ra n�gra presenter!");
        CollectionAssert.Contains(_player.Inventory, _magicItem);
    }

    [TestMethod]
    public void AddItem_WhenInventoryFull_ReturnsFalse()
    {
        // Arrange - Fyller spelarens inventarie med 5 presenter
        for (int i = 0; i < 500; i++)
        {
            _player.AddItem(new Item($"Present {i}", "En julklapp"));
        }

        // Act - F�rs�ker l�gga till en magisk klocka n�r inventariet �r fullt
        var result = _player.AddItem(_magicItem);

        // Assert - Kontrollera att resultatet �r falskt eftersom inventariet �r fullt
        Assert.IsFalse(result, "Ho ho NO! Tomten kan inte b�ra o�ndligt m�nga saker!");
    }
}*/