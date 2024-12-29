/*[TestClass]
public class ElfTests
{
    private WorkshopElf _elf;

    // Denna metod k�rs innan varje test f�r att st�lla in n�dv�ndiga objekt
    [TestInitialize]
    public void Setup()
    {
        // Skapar en ny tomtenisse med namnet "Glader"
        _elf = new WorkshopElf("Glader");
    }

    // Testar att tomtenissen kan skapa en leksak n�r den inte �r tr�tt
    [TestMethod]
    public void MakeToy_WhenNotTired_CreatesToy()
    {
        // Act - F�rs�ker skapa en leksak
        var toy = _elf.MakeToy();

        // Assert - Kontrollera att leksaken inte �r null och att dess kvalitet �r minst 8
        Assert.IsNotNull(toy, "Leksaken ska inte vara null");
        Assert.IsTrue(toy.Quality >= 8, "Tomtenissar g�r alltid bra leksaker!");
    }

    // Testar att ett undantag kastas n�r tomtenissen �r utmattad
    [TestMethod]
    public void MakeToy_WhenExhausted_ThrowsException()
    {
        // Arrange - L�ter tomtenissen skapa 100 leksaker f�r att g�ra den tr�tt
        for (int i = 0; i < 100; i++)
        {
            _elf.MakeToy();
        }

        // Act & Assert - F�rs�ker skapa en leksak och f�rv�ntar sig ett undantag
        var ex = Assert.ThrowsException<ExhaustedElfException>(
            () => _elf.MakeToy());

        // Kontrollera att undantagsmeddelandet inneh�ller ordet "fika"
        StringAssert.Contains(ex.Message, "fika", "Tr�tta tomtenissar beh�ver fika!");
    }
}*/