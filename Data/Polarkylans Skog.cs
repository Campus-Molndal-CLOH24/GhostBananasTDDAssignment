public class PolarkylansSkog : Room
{
	// Logiken för interaktioner (t.ex. kasta värmekudden, ge gåtor) hanteras i CommandHandler eller GameEngine
	public PolarkylansSkog()
	{
		Name = "Polarkylans Skog";
		Description = "Du befinner dig i en gnistrande vinterskog. Någonstans här finns den talande isräven. " +
					  "Var kan han vara? (i sin lya, åker skridskor på sjön, plockar isblommor)";

		Items = new List<Item>();
	}
}
