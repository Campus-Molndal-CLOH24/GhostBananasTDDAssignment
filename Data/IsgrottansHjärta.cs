using GhostBananasTDDAssignment.Data;
using System.Collections.Generic;


    public class IsgrottansHjarta : Room
    {
        public IsgrottansHjarta()
        {
            Name = "Isgrottans Hj�rta";
            Description = "Du befinner dig i Isgrottans allra innersta rum. V�ggarna av tjock is glimmar i skenet " +
                          "fr�n en ensam islykta, och golvet �r t�ckt av frostblommor. " +
                          "Mitt i rummet st�r den fruktade Marcus, ikl�dd en luva, med ett isklot i h�nderna. " +
                          "Din v�rmekudde kan kanske sm�lta isklotet och befria presenterna. " +
                          "N�r isklotet sm�lter dyker pepparkakshj�lten fram och snor �t sig s�cken. " +
                          "Men Marcus vakter formar en ogenomtr�nglig mur framf�r utg�ngen. " +
                          "Du erbjuder Marcus en g�ta:\n" +
                          "\"Du kommer till ett v�gsk�l d�r en v�g leder till en skatt och den andra leder till s�ker d�d.\"\n" +
                          "Ska Marcus svara r�tt eller fel? Fel = du g�r fri, r�tt = du delar dina julklappar.\n\n" +
                          "Rummet doftar svagt av isblommor och du h�r ett svagt droppande ljud n�r iskristaller sm�lter " +
                          "l�ngsamt under din andedr�kt.";

            Items = new List<Item>
        {
            new Item("Islyktan", "En vackert uthuggen lykta av is, den enda ljusk�llan i rummet."),
            new Item("Frostblommor", "�mt�liga, glittrande isblommor som v�xer ur golvets sprickor."),
            new Item("Glasbit", "En sk�rva av iskristall fr�n v�ggen, kall och hal i handen."),
            new Item("Isnyckel", "En nyckel formad av is. Kanske kan den �ppna n�got l�ngre fram."),
        };
        }
    }