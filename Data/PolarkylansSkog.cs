using GhostBananasTDDAssignment.Data;

public class PolarkylansSkog : Room
{
   
    public PolarkylansSkog()
    {
        Name = "Polarkylans Skog";
        Description = "Du befinner dig i en gnistrande vinterskog där det skira ljuset bryts i kristallklara isflingor. " +
                      "Trädstammarna är täckta av rimfrost och marken knarrar under dina steg. " +
                      "I fjärran hörs ett avlägset ylande – det sägs att en talande isräv gömmer sig här. " +
                      "Var kan han vara? (i sin lya, åker skridskor på sjön, plockar isblommor) " +
                      "Du känner en lätt bris som får isflingorna i grenarna att rassla som små klockor.";

        Items = new List<Item>
        {
            new Item("Isblomma", "En spröd, frostig blomma som skimrar i det svaga ljuset. Känslig och vacker."),
            new Item("Iskristall", "En klar kristall av ren is. Den bryter ljuset i vackra mönster."),
            new Item("Snötäcke", "Ett hopvikbart täcke vävt av snöflingor (ser mystiskt varmt ut trots allt)."),
            new Item("Frostnyckel", "En nyckel formad av iskristaller, kanske kan den öppna något längre fram.")
        };
    }
}

