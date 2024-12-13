[TestClass]
public class PlayerTests
{
    private Player _player;
    private Item _magicItem;

    [TestInitialize]
    public void Setup()
    {
        // Skapar en ny spelare och en magisk klocka innan varje test
        _player = new Player("TestTomte");
        _magicItem = new Item("Magisk Klocka", "Ringer själv vid midnatt")
        {
            IsMagical = true,
            Weight = 5
        };
    }

    [TestMethod]
    public void AddItem_WhenInventoryNotFull_ReturnsTrue()
    {
        // Arrange är redan fixat i Setup

        // Act - Försöker lägga till en magisk klocka i spelarens inventarie
        var result = _player.AddItem(_magicItem);

        // Assert - Kontrollera att resultatet är sant och att klockan finns i inventariet
        Assert.IsTrue(result, "Tomten måste kunna bära några presenter!");
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

        // Act - Försöker lägga till en magisk klocka när inventariet är fullt
        var result = _player.AddItem(_magicItem);

        // Assert - Kontrollera att resultatet är falskt eftersom inventariet är fullt
        Assert.IsFalse(result, "Ho ho NO! Tomten kan inte bära oändligt många saker!");
    }
}