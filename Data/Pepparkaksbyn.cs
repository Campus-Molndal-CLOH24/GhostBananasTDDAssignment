using System.Collections.Generic;

public class Pepparkaksbyn : Room
{
    public Pepparkaksbyn()
    {
        Name = "Pepparkaksbyn";
        Description = "Du befinner dig i Pepparkaksbyn, d�r husen, marken och till och med " +
                      "slottet i fj�rran �r gjort av pepparkaka och glasyr. " +
                      "En doft av kanel, nejlika och ingef�ra fyller luften. " +
                      "I ett stort pepparkaksslott finns ett k�k d�r du kan h�mta deg " +
                      "genom att krypa under bordet. Nu n�r du har degen i handen, " +
                      "vad ska du g�ra nu?\n\n" +
                      "Alternativ:\n" +
                      "- Baka en superhj�ltepepparkaka som ska sl�ss mot Marcus. (R�TT)\n" +
                      "- �t upp all deg (FEL)\n" +
                      "- Rid p� en pepparkaksgris (FEL)\n\n" +
                      "V�ljer du fel f�rlorar du ett liv!";

        Items = new List<Item>
        {
            new Item("Degen", "En klump pepparkaksdeg som du h�mtat fr�n k�ket under ett bord.")
            // L�gga till fler Items om du beh�vs.
        };
    }
}
