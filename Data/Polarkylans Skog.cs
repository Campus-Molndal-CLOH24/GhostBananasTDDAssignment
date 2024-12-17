public class PolarkylansSkog : Room
{
	// Logiken f�r spelvalen och g�tan hanteras inte h�r, utan t.ex. i CommandHandler.
	public PolarkylansSkog()
	{
		Name = "Polarkylans Skog";
		Description = "Du befinner dig i en gnistrande vinterskog. N�gonstans h�r finns den talande isr�ven. " +
					  "Var kan han vara? (i sin lya, �ker skridskor p� sj�n, plockar isblommor)";

		Items = new List<Item>();
	}
}
