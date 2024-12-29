using System.Collections.Generic;
using GhostBananasTDDAssignment.Data;

public class Tomteland : Room
{
    public Tomteland() 
    {
        Name = "Tomteland";
        Description = "Du st�r mitt i Tomteland, omgiven av sn�t�ckta granar och f�rgglada paket. " +
                      "Det doftar pepparkakor och gl�gg, och i bakgrunden h�rs jultoner fr�n 'Nu �r det jul h�r i v�rt hus'. " +
                      "P� ett bord ser du en station f�r paketinslagning, och p� golvet ligger en trasig leksak som n�gon verkar ha gl�mt. " +
                      "Ljuset fr�n en julstj�rna glimmar varmt i ett f�nster. En r�st viskar: 'Grattis, du f�r ett extra liv!'";

        Items = new List<Item>
        {
            new Item("Limtub", "En liten tub med superlim � perfekt f�r att laga trasiga leksaker."),
            new Item("Inslagningspapper", "Glittrigt papper att sl� in julklappar i."),
            new Item("Trasig Leksak", "En s�nderfallen liten tr�docka som beh�ver limmas ihop."),
            new Item("Pepparkakshj�rta", "Ett stort hj�rta av pepparkaka med texten 'God Jul!' ingraverat.")
        };
    }
}
