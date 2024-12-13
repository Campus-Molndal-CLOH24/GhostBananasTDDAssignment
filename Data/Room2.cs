public class ReindeerStable : Room
{
	public ReindeerStable()
	{
		Name = "Renstallet";
		Description = "Ett varmt stall d�r renarna vilar. " +
					 "Rudolfs n�sa lyser upp rummet.";
		Items = new List<Item>
		{
			new Item("Morot", "Rudolfs favorit!")
		};
	}
}