using System.Collections.Generic;
using GhostBananasTDDAssignment.Data;

public class RudolfsHed : Room
{

    public RudolfsHed()
    {
        Name = "Rudolfs Hed";
        Description = "Du st�r p� en vidstr�ckt, sn�t�ckt hed d�r Rudolf brukar tr�na sina flygningar. " +
                      "Den kalla vinden biter i kinderna och du kan se sp�r i sn�n som leder �t olika h�ll. " +
                      "Rudolf syns inte till. Var g�mmer han sig? (sn�n, stallet, bastun)\n\n" +
                      "P� avst�nd h�rs dova bj�llror fr�n andra renar, och luften doftar svagt av gran. " +
                      "Det �r stilla, men du anar att n�got eller n�gon g�mmer sig i det vita landskapet.";

        Items = new List<Item>
        {
            new Item("H�bunt", "En liten bunt torrt h�, perfekt f�r att locka fram en hungrig ren."),
            new Item("Renbj�llra", "En bj�llra som renarna brukar b�ra. Den klirrar fint och kan anv�ndas f�r att f� uppm�rksamhet."),
            new Item("V�rmeschal", "En l�ng, stickad schal som v�rmer i den isiga vinden."),
            new Item("Sn�skyffel", "En liten skyffel som kan anv�ndas f�r att gr�va i sn�n, kanske f�r att leta efter n�got g�mt.")
        };
    }
}
