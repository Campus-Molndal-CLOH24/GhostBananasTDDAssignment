public class IsgrottansHjarta : Room
{
	// Logiken för interaktioner (t.ex. kasta värmekudden, ge gåtor) hanteras i CommandHandler eller liknande.
	public IsgrottansHjarta()
	{
		Name = "Isgrottans Hjärta";
		Description = "Du står inför den fruktade Marcus, som håller i ett isklot. " +
					  "Värmekudden kan smälta isklotet, pepparkakshjälten dyker upp och tar säcken. " +
					  "Marcus vakter blockerar dörren! Du erbjuder en gåta: " +
					  "\n\"Du kommer till ett vägskäl där en väg leder till en skatt och den andra leder till säker död.\"" +
					  "\nSka Marcus svara rätt eller fel? Fel = du går fri, rätt = du delar dina julklappar.";

		Items = new List<Item>();
	}
}
