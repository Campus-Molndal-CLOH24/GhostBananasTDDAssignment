using System.Collections.Generic;

public class Pepparkaksbyn : Room
{
    public Pepparkaksbyn() // Logiken för interaktioner hanteras i CommandHandler eller GameEngine
    {
        Name = "Pepparkaksbyn";
        Description = "Du befinner dig i Pepparkaksbyn, där allt från husen till marken är gjort av pepparkaka och glasyr. " +
                      "Den söta doften av kanel, nejlika och ingefära ligger tung i luften. " +
                      "I fjärran skymtar du ett stort pepparkaksslott och i dess kök hittar du deg " +
                      "genom att krypa under ett stort bord. Nu, med degen i handen, måste du välja hur du ska använda den:\n\n" +
                      "Alternativ:\n" +
                      "- Baka en superhjältepepparkaka som ska slåss mot Marcus. (RÄTT)\n" +
                      "- Ät upp all deg (FEL)\n" +
                      "- Rid på en pepparkaksgris (FEL)\n\n" +
                      "Väljer du fel förlorar du ett liv!\n\n" +
                      "Runt omkring dig prasslar det av knastrande pepparkaksstigar, och du kan nästan höra nissar fnissa bakom ett knäckebrunt hörn.";

        Items = new List<Item>
        {
            new Item("Degen", "En smidig klump pepparkaksdeg, färdig att formas till något hjältemodigt."),
            new Item("Pepparkaksmjöl", "Ett fint pulver av krossad pepparkaka, doftar kryddigt."),
            new Item("Glasyrpennan", "Ett litet rör fylld med söt glasyr, perfekt för att dekorera din skapelse."),
            new Item("Kanelstång", "En doftande kanelstång, kanske kan den användas för att locka fram något ur skuggorna.")
        };
    }
}
