using System.Collections.Generic;
using GhostBananasTDDAssignment.Data;

public class PolarkylansSkog : Room
{
   
    public PolarkylansSkog()
    {
        Name = "Polarkylans Skog";
        Description = "Du befinner dig i en gnistrande vinterskog d�r det skira ljuset bryts i kristallklara isflingor. " +
                      "Tr�dstammarna �r t�ckta av rimfrost och marken knarrar under dina steg. " +
                      "I fj�rran h�rs ett avl�gset ylande � det s�gs att en talande isr�v g�mmer sig h�r. " +
                      "Var kan han vara? (i sin lya, �ker skridskor p� sj�n, plockar isblommor) " +
                      "Du k�nner en l�tt bris som f�r isflingorna i grenarna att rassla som sm� klockor.";

        Items = new List<Item>
        {
            new Item("Isblomma", "En spr�d, frostig blomma som skimrar i det svaga ljuset. K�nslig och vacker."),
            new Item("Iskristall", "En klar kristall av ren is. Den bryter ljuset i vackra m�nster."),
            new Item("Sn�t�cke", "Ett hopvikbart t�cke v�vt av sn�flingor (ser mystiskt varmt ut trots allt)."),
            new Item("Frostnyckel", "En nyckel formad av iskristaller, kanske kan den �ppna n�got l�ngre fram.")
        };
    }
}

