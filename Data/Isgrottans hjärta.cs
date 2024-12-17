public class IsgrottansHjarta : Room
{
	// Logiken f�r interaktioner (t.ex. kasta v�rmekudden, ge g�tor) hanteras i CommandHandler eller liknande.
	public IsgrottansHjarta()
	{
		Name = "Isgrottans Hj�rta";
		Description = "Du st�r inf�r den fruktade Marcus, som h�ller i ett isklot. " +
					  "V�rmekudden kan sm�lta isklotet, pepparkakshj�lten dyker upp och tar s�cken. " +
					  "Marcus vakter blockerar d�rren! Du erbjuder en g�ta: " +
					  "\n\"Du kommer till ett v�gsk�l d�r en v�g leder till en skatt och den andra leder till s�ker d�d.\"" +
					  "\nSka Marcus svara r�tt eller fel? Fel = du g�r fri, r�tt = du delar dina julklappar.";

		Items = new List<Item>();
	}
}
