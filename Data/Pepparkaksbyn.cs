using System.Collections.Generic;

public class Pepparkaksbyn : Room
{
    public Pepparkaksbyn()
    {
        Name = "Pepparkaksbyn";
        Description = "Du befinner dig i Pepparkaksbyn, där husen, marken och till och med " +
                      "slottet i fjärran är gjort av pepparkaka och glasyr. " +
                      "En doft av kanel, nejlika och ingefära fyller luften. " +
                      "I ett stort pepparkaksslott finns ett kök där du kan hämta deg " +
                      "genom att krypa under bordet. Nu när du har degen i handen, " +
                      "vad ska du göra nu?\n\n" +
                      "Alternativ:\n" +
                      "- Baka en superhjältepepparkaka som ska slåss mot Marcus. (RÄTT)\n" +
                      "- Ät upp all deg (FEL)\n" +
                      "- Rid på en pepparkaksgris (FEL)\n\n" +
                      "Väljer du fel förlorar du ett liv!";

        Items = new List<Item>
        {
            new Item("Degen", "En klump pepparkaksdeg som du hämtat från köket under ett bord.")
            // Lägga till fler Items om du behövs.
        };
    }
}
