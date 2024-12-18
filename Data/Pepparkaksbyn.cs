using System.Collections.Generic;

public class Pepparkaksbyn : Room
{
    public Pepparkaksbyn() // Logiken f�r interaktioner hanteras i CommandHandler eller GameEngine
    {
        Name = "Pepparkaksbyn";
        Description = "Du befinner dig i Pepparkaksbyn, d�r allt fr�n husen till marken �r gjort av pepparkaka och glasyr. " +
                      "Den s�ta doften av kanel, nejlika och ingef�ra ligger tung i luften. " +
                      "I fj�rran skymtar du ett stort pepparkaksslott och i dess k�k hittar du deg " +
                      "genom att krypa under ett stort bord. Nu, med degen i handen, m�ste du v�lja hur du ska anv�nda den:\n\n" +
                      "Alternativ:\n" +
                      "- Baka en superhj�ltepepparkaka som ska sl�ss mot Marcus. (R�TT)\n" +
                      "- �t upp all deg (FEL)\n" +
                      "- Rid p� en pepparkaksgris (FEL)\n\n" +
                      "V�ljer du fel f�rlorar du ett liv!\n\n" +
                      "Runt omkring dig prasslar det av knastrande pepparkaksstigar, och du kan n�stan h�ra nissar fnissa bakom ett kn�ckebrunt h�rn.";

        Items = new List<Item>
        {
            new Item("Degen", "En smidig klump pepparkaksdeg, f�rdig att formas till n�got hj�ltemodigt."),
            new Item("Pepparkaksmj�l", "Ett fint pulver av krossad pepparkaka, doftar kryddigt."),
            new Item("Glasyrpennan", "Ett litet r�r fylld med s�t glasyr, perfekt f�r att dekorera din skapelse."),
            new Item("Kanelst�ng", "En doftande kanelst�ng, kanske kan den anv�ndas f�r att locka fram n�got ur skuggorna.")
        };
    }
}
