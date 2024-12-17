public class ReindeerStable : Room
{
	public ReindeerStable()
	{
		Name = "Renstallet";
		Description = "Ett varmt stall där renarna vilar. " +
					 "Rudolfs näsa lyser upp rummet.";
		Items = new List<Item>
		{
			new Item("Morot", "Rudolfs favorit!")
		};
	}
}