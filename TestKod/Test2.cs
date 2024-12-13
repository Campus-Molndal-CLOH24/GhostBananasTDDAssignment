[TestClass]
public class ElfTests
{
    private WorkshopElf _elf;

    // Denna metod körs innan varje test för att ställa in nödvändiga objekt
    [TestInitialize]
    public void Setup()
    {
        // Skapar en ny tomtenisse med namnet "Glader"
        _elf = new WorkshopElf("Glader");
    }

    // Testar att tomtenissen kan skapa en leksak när den inte är trött
    [TestMethod]
    public void MakeToy_WhenNotTired_CreatesToy()
    {
        // Act - Försöker skapa en leksak
        var toy = _elf.MakeToy();

        // Assert - Kontrollera att leksaken inte är null och att dess kvalitet är minst 8
        Assert.IsNotNull(toy, "Leksaken ska inte vara null");
        Assert.IsTrue(toy.Quality >= 8, "Tomtenissar gör alltid bra leksaker!");
    }

    // Testar att ett undantag kastas när tomtenissen är utmattad
    [TestMethod]
    public void MakeToy_WhenExhausted_ThrowsException()
    {
        // Arrange - Låter tomtenissen skapa 100 leksaker för att göra den trött
        for (int i = 0; i < 100; i++)
        {
            _elf.MakeToy();
        }

        // Act & Assert - Försöker skapa en leksak och förväntar sig ett undantag
        var ex = Assert.ThrowsException<ExhaustedElfException>(
            () => _elf.MakeToy());

        // Kontrollera att undantagsmeddelandet innehåller ordet "fika"
        StringAssert.Contains(ex.Message, "fika", "Trötta tomtenissar behöver fika!");
    }
}