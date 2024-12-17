public class Workshop : Room
{
	public Workshop()
	{
		Name = "Tomteverkstaden";
		Description = "En mysig verkstad full med leksaker och verktyg. " +
					 "Det doftar kanel och gran.";
		Items = new List<Item>
		{
			new Item("Magisk Hammare", "Perfekt f�r att bygga julklappar !")
		};
	}
}