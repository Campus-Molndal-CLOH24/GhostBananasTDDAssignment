public class PolarkylansSkog : Room
{
	// Logiken för spelvalen och gåtan hanteras inte här, utan t.ex. i CommandHandler.
	public PolarkylansSkog()
	{
		Name = "Polarkylans Skog";
		Description = "Du befinner dig i en gnistrande vinterskog. Någonstans här finns den talande isräven. " +
					  "Var kan han vara? (i sin lya, åker skridskor på sjön, plockar isblommor)";

		Items = new List<Item>();
	}
}
